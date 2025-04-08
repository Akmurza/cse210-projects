using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
    }
    public void Run()
    {
        
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds (_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine( );
            Console.Write("Breathe in.....");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out..");
            ShowCountDown(6);
            Console.WriteLine ();
        }
        DisplayEndingMessage();
    }
}