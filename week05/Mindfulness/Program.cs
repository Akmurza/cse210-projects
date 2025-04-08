using System;

class Program
{
    static void Main(string[] args)
    {
        bool runningProgram = true;
        while (runningProgram)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1.Breathing exercise");
            Console.WriteLine("2.Listing exercise");
            Console.WriteLine("3.Reflection exercise");
            Console.WriteLine("4. Quit");
            
            string chosenActivityCode = Console.ReadLine();
            Console.Clear();
            
            if (chosenActivityCode == "1")
            {
            BreathingActivity breathing = new BreathingActivity("Breathing.......", 
            "This activity will help you relax a bit you through breathing in and out slowly.", 0);
             breathing.Run();
            }
            else if (chosenActivityCode == "2")
            {
                ListingActivity listing = new ListingActivity("Listing..",
                "This activity will help you reflect on good things in your life by having you list as many things as you can.", 0);
            listing.Run();
            }
            else if (chosenActivityCode == "3")
            {
                ReflectingActivity reflection = new ReflectingActivity("Reflection!",
                    "This activity will help you reflect your life when you have shown strength and resilience.", 0);
            reflection.Run();
            }
            else if (chosenActivityCode == "4")
            {
            runningProgram = false;
            }
            else
            {
            Console.WriteLine("Invalid option. Press any key to continue...");
            Console.ReadKey();
            }
        }
    }
}