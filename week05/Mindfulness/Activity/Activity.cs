public class Activity{ 

    protected int secondsInt; 
    protected string activityName;

    public Activity()
    {
        activityName = GetType().Name;
    }

    public void StartExercise() 
    {
        Console.WriteLine("Welcome to the mindfulness exercises!");
        System.Console.WriteLine(
            "In this section, we will guide you through a series exercises." +
            "\n\n" +
            "These exercises are designed to help you relax and focus your mind. Get ready for the start and concentrate" +
            "\n\n" +
            "Press number how many seconds do you want to participate in this activity?");
        string seconds = Console.ReadLine();
        secondsInt = int.Parse(seconds);
        Console.WriteLine($"You have chosen to participate for {seconds} seconds.");

    }
    public void EndExercise()
    {
        Thread.Sleep(3000);//TODO: make spiner!!
        Console.WriteLine("Thank you for participating in the mindfulness exercise!");
        Console.WriteLine($"We hope you feel more relaxed and focused. You have completed {secondsInt} seconds of {activityName}");
        Console.WriteLine("Have a great day!");
    }
}
