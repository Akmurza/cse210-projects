public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.Name}' added.");
    }


    //lists the names of the goals that you have
    public void ListGoalNames(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
            {
                Console.WriteLine(goal.Name);
            }
        }
    }


    //shows the player score and the goals
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            goal.DisplayGoal();
        }
    }


    //saves the goals to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Points},{goal.IsComplete}");
            }
        }
    }
    

    //lists the details of a specific goal
    public void ListGoalDetails(string goalName)
    {
        var goal = _goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    //creates a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Creating a new goal...");

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());
        
        Goal newGoal = new Goal(name, points);
        _goals.Add(newGoal);
        Console.WriteLine($"Goal '{name}' created with {points} points.");


    }


    //records an event for an goal
    public void RecordEvents()
    {
        Console.WriteLine("Recording events for goals...");
        foreach (var goal in _goals)
        {
            goal.RecordEvent();
        }
    }
    

    

    //loads the goals from a file
    public void LoadGoals(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string name = parts[0];
                    int points = int.Parse(parts[1]);
                    bool isComplete = bool.Parse(parts[2]);

                    Goal goal = new Goal(name, points, isComplete);
                    _goals.Add(goal);
                }
            }
        }
    }

}