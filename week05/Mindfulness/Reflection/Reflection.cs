public class Reflection:Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you made a difference in someone's life."
    };

    private string _prompt;
    private string _reflection;

    public Reflection()
    {
        _prompt = GetRandomPrompt();
        _reflection = "";
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void StartExercise()
    {
        base.StartExercise();
        Console.Clear();
        Console.WriteLine("Reflection Exercise: " + _prompt);
        Console.WriteLine("Take a moment to reflect on this prompt and write down your thoughts.");
        Console.WriteLine("Press Enter when you are ready to continue...");
        Console.ReadLine();

        Console.WriteLine("Your reflection: ");
        _reflection = Console.ReadLine();

        Console.WriteLine("Thank you for your reflection!");
        EndExercise();
    
}

}