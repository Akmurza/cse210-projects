public class Breathing : Activity{

    public void BreathingActivity()
    {
        // 
        base.StartExercise();
        
        Console.Clear();
        Console.WriteLine("Breathing Exercise 1: Deep Breathing");
        
     
        int remainingTime = secondsInt; // 
        
        while (remainingTime > 0)
        {
            Console.WriteLine("\nInhale deeply through your nose...");
            Thread.Sleep(4000);

            
            Console.WriteLine("Hold your breath...");
            Thread.Sleep(4000);
            
            Console.WriteLine("Exhale slowly through your mouth...");
            Thread.Sleep(4000);
            
            remainingTime -= 12;  

            System.Console.WriteLine("Prepare for the next breath cycle");
            Thread.Sleep(2000);
        }
        
        base.EndExercise();
    }
// Compare this snippet from week05/Mindfulness/Listing/Listing.cs:
// public class Listing : Activity{
//     private List<string> _prompts = new List<string>
//     {
//         "Think of a time when you stood up for someone else.",
//         "Think of a time when you did something really difficult.",
//         "Think of a time when you helped someone in need.",
//         "Think of a time when you made a difference in someone's life."

}
