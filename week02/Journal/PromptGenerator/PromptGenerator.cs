using System;
using System.Reflection.Metadata.Ecma335;
namespace MyProject;

public class PromptGenerator
{
    public static void Prompt()
    {
        List<string>_prompts=new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see God's hand in my life today?");
        _prompts.Add("What was the most powerful emotion I experienced today??");
        _prompts.Add("If I could do one thing today, what would it be?");
        Random random=new Random();
        int randomIndex = random.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[randomIndex]}");


    }
}