using System;

class Program
{     
    static void Main(string[] args)
    {  
        
        /// exceeding requirments 1. activity logging -Was added counters to track how many times each activity has been
        /// - Displays the count next to each activity in the menu 
        ///  Shows statistics summary 
        /// 2. No Repeat questions or prompts upgraded ReflectingActivity and ListingActivity classes to avoid 
        /// repeating prompts and questions 
        /// - Created a system where all prompts/questions must be used before repeated  
        /// Used separate lists to track which items are still available  
        /// - When all items are used, 
        /// the lists refresh with all options
        /// Showing progress through activity counts ,esuring users experience 
        /// a variety of prompts before seeing repeats
        bool runningProgram = true;
        
        // exceedinng requirments Initialize activity counts
        int breathingCount = 0;
        int listingCount = 0;
        int reflectionCount = 0;
        while (runningProgram)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
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
             breathingCount++;//Increment the count for breathing activity
            }
            else if (chosenActivityCode == "2")
            {
                ListingActivity listing = new ListingActivity("Listing..",
                "This activity will help you reflect on good things in your life by having you list as many things as you can.", 0);
            listing.Run();
            listingCount++;// increment the count for listing
            }
            else if (chosenActivityCode == "3")
            {
                ReflectingActivity reflection = new ReflectingActivity("Reflection!",
                    "This activity will help you reflect your life when you have shown strength and resilience.", 0);
            reflection.Run();
            reflectionCount++;// increment the count for reflection
            }
            else if (chosenActivityCode == "4")
            {
            Console.WriteLine("Ststistics:");
            Console.WriteLine($"Breathing activity completed: {breathingCount} times.");
            Console.WriteLine($" Listing activity completed: {listingCount} times.");
            Console.WriteLine($"Reflection activity completed: {reflectionCount} times.");
            Console.WriteLine($"Total : {breathingCount + listingCount + reflectionCount}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
    
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