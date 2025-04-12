using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start(new SimpleGoal("Run 5 miles", "Run 5 miles in one go", 10));
        Console.WriteLine("Goal added.");

    


    }
}