using System.Collections.Generic;
using System.IO;
using System;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;               //defaul values
        }
        
        public void Start()
        {    
            bool run = true;//eternal cycle in eternal quest
            while(run)
            {
                Console.Clear();  // Main menu
                Console.WriteLine($"You have {_score} points\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("\nSelect from the menu: ");

                string choice = Console.ReadLine();
                Console.Clear();  

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
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
                        Console.WriteLine("Invalid choice press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    
        //creates a new goal
        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of goals are:");
            Console.WriteLine("1.Simple goal");
            Console.WriteLine("2.Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.Write("Which type of goal would you like to create? ");
            string choice = Console.ReadLine();
            Console.WriteLine("\n");

            // common fields for all goals
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is the amount of points for this goal? ");
            int points = int.Parse(Console.ReadLine());

            //we have made inner variables of the method and gonne give them to specific classes
            //and create the goal object of the specific class
            Goal newGoal;//just initialized it before the switch statement another way dosen't work
            switch (choice)
            {
                case "1":
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                    
                case "2":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                    
                case "3": //in this case just get all the data we need in one place
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
            Console.WriteLine($"\nGoal '{name}' created");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


// lists the details of the goals that you have
        public void ListGoalDetails()
        {
            Console.WriteLine("\nYour Goals:");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created.");
            }
            else
            {
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                }
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
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

        //records an event for a goal
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
                int pointsEarned = selectedGoal.RecordEvent();
                _score += pointsEarned;

                Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} total points.");
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

            if (File.Exists(filename))
            {
                _goals.Clear();
                
                using (StreamReader reader = new StreamReader(filename))
                {
                    string scoreLine = reader.ReadLine();
                    _score = int.Parse(scoreLine);

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
            }
            else
            {
                Console.WriteLine($"\nFile {filename} not found.");
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

          // this method converts a string from a file back 
         // to a Goal object. It is used when loading goals from a file.
        //the method called in LoadGoals()

        private Goal CreateGoalFromString(string goalString)
        {
            string[] parts = goalString.Split(':');
            if (parts.Length != 2) return null;// invalid format if we get null we know it

            string goalType = parts[0];               //  (SimpleGoal, EternalGoal, etc)
            string[] goalData = parts[1].Split(','); // split by comma

            switch (goalType)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                    if (bool.Parse(goalData[3])) simpleGoal.RecordEvent();
                    return simpleGoal;

                case "EternalGoal":
                    return new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));

                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(
                        goalData[0],                // name 
                        goalData[1],               // description
                        int.Parse(goalData[2]),   // points
                        int.Parse(goalData[4]),  // target
                        int.Parse(goalData[5])  // bonus
                    );
                    
                    // restore progress
                    int completions = int.Parse(goalData[3]);
                    for (int i = 0; i < completions; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    return checklistGoal;
            }
            return null;
        }





//  added method to check levels of goals

        public void CheckLevels()
        {
            foreach (Goal goal in _goals)
            {
                // check if goal is levelable
                if (goal is ILevelable levelable)
                {
                    // check if goal can level up
                    if (levelable.CanLevelUp())
                    {
                        // get bonus points
                        int bonusPoints = levelable.ProcessLevelUp();
                        _score += bonusPoints;
                        
                        // show info Level UP!
                        Console.WriteLine($"Level Up! {goal.Name} reached level {levelable.GetLevel()}");
                        Console.WriteLine($"Bonus points earned: {bonusPoints}");
                    }
                }
            }
        }
    }
}