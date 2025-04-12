using System;

class Program
{
    static void Main(string[] args)
    {
        // Удалим лишние сообщения и параметр в Start()
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}