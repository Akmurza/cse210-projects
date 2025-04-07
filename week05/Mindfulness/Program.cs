using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        System.Console.WriteLine(
            "This project is designed to help you practice mindfulness and improve your mental well-being." +
            "\n\n" +
            "We will guide you through a series of exercises that focus on breathing, meditation, and self-reflection." +
            "\n\n" +
            "Let's get started!" +
            "\n\n" +
            "Press number of preferable activity to continue..."+
            "\n\n" +
            "1. Breathing Exercise" +
            "\n 2. Listing Exercise" +
            "\n\n" +
            "3. Reflection Exercise" + 
            "\n\n" +
            "4. Quit " 
        );
        string chosenActivityCode=Console.ReadLine();
        Console.Clear();
        if (chosenActivityCode == "1")
        {
            Breathing breathing = new Breathing();
            breathing.StartExercise();
        }
        else if (chosenActivityCode == "2")
        {
            Listing listing = new Listing();
            listing.StartExercise();
        }
        else if (chosenActivityCode == "3")
        {
            Reflection reflection = new Reflection();
            reflection.StartExercise();
        }
        else if (chosenActivityCode == "4")
        {
            Console.WriteLine("Thank you for participating! Have a great day!");
            return;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }



        

        
        
    }
}
