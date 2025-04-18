using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _redundantPrompts;//add list to store redundant prompts
    private int _count;

    public ListingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        _prompts = new List<string> 
        { 
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;

        RenewRedundantPrompts();
    }

    private void RenewRedundantPrompts()
    {
        _redundantPrompts = new List<string>(_prompts);
    }
    public string GetRandomPrompt()
    {   

        if (_redundantPrompts.Count == 0)
        {
        RenewRedundantPrompts();
        }
        Random random = new Random();
        int index = random.Next(_redundantPrompts.Count);
        string prompt = _redundantPrompts[index];
        _redundantPrompts.RemoveAt(index);
        return prompt;
        
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        return items;
    }
    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" {prompt} ");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        
        
        List<string>  items = GetListFromUser();

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}