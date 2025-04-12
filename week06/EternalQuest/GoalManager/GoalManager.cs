public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool run = true:
        while(run)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List GoalNames");
            Console.WriteLine("3. Save Goals to File");
            Console.WriteLine("4. Load Goals from File");
            Console.WriteLine("5. Record Events for Goals");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames(); 
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                
                case "3":
                    SaveGoals();
                    break;
                
                
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvents();
                    break;
                case "6":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        }
    }
 
    //creates a new goal
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.WriteLine("\n");

        // common fields for all goals
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;
        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
                
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
                
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
                
            default:
                Console.WriteLine("Invalid type!");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine($"\nGoal '{name}  'created");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    } 




    //lists the names of the goals that you have
    public void ListGoalNames()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No one goals created.");
            return;
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                string completionStatus = _goals[i].IsComplete ? "[X]":"[ ]";
                Console.WriteLine($"{i + 1}. {completionStatus} {_goals[i].Name}");
            }
        }
            Console.WriteLine(); // just to separate the output from the menu options 
    }



    //saves the goals to a file
    public void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"\nGoals saved to {filename}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    



    //records an event for an goal
    public void RecordEvents()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to record events for.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("\nWhich goal did you accomplish? ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            
            // Записываем событие и получаем очки
            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("\nInvalid goal number.");
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    



    //loads the goals from a file
    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filename))
        {
            // Сначала читаем общий счет
            string scoreLine = reader.ReadLine();
            _score = int.Parse(scoreLine);

            // Читаем все цели
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = CreateGoalFromString(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }

        Console.WriteLine($"\nGoals loaded from {filename}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private Goal CreateGoalFromString(string goalString)
    {
        string[] parts = goalString.Split(':');
        string goalType = parts[0];
        string[] goalData = parts[1].Split(',');

        switch (goalType)
        {
            case "SimpleGoal":
                return new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                
            case "EternalGoal":
                return new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                
            case "ChecklistGoal":
                return new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), 
                       int.Parse(goalData[4]), int.Parse(goalData[5]));
                
            default:
                return null;
        }
    }
}