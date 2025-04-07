public class Activity{ 

    public void StartExercise() 
    {
        Console.WriteLine("Welcome to the mindfulness exercises!");
        System.Console.WriteLine(
            "In this section, we will guide you through a series exercises." +
            "\n\n" +
            "These exercises are designed to help you relax and focus your mind. Get ready for the start and concentrate" +
            "\n\n" +
            "Press number how many seconds do you want to participate in this activity?"
        );
        string seconds = Console.ReadLine();
        Console.WriteLine($"You have chosen to participate for {seconds} seconds.");

}
}
