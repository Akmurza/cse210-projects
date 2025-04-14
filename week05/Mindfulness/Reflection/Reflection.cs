using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _redundantPrompts;//added list to store redundant prompts
    private List<string> _redundantQuestions;//added list to store redundant questions

    public ReflectingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        //init 
        RenewRedundantPrompts();
        RenewRedundantQuestions();
    }
        //update lists to remove used prompts and questions
        private void RenewRedundantPrompts()
        {
            _redundantPrompts = new List<string>(_prompts);
        }
        private void RenewRedundantQuestions()
        {
            _redundantQuestions = new List<string>(_questions);
        }






    
    public string GetRandomPrompt()
    {
        
        if (_redundantPrompts.Count == 0)
        {
            RenewRedundantPrompts();
        }
        Random random = new Random();
        int index = random.Next(_redundantQuestions.Count);
        string question=_redundantQuestions[index];
        _redundantQuestions.RemoveAt(index); // remove the used question
        return question;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" {prompt} ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine();
        Console.WriteLine($"{question}");
    }
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
}