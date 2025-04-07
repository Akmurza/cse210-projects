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
}
