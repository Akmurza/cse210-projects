using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();//list of activities
        DateTime currentDate = DateTime.Now; //instance of each activity type
        
        Running runningActivity = new Running(currentDate, 30, 3.0);//running activity: date, minutes, distance in miles
        activities.Add(runningActivity);
        
        Cycling cyclingActivity = new Cycling(currentDate, 45, 15.0);// cycling- date, minutes, speed
        activities.Add(cyclingActivity);
        
        Swimming swimmingActivity = new Swimming(currentDate, 60, 20);// swim date, minutes, number of laps
        activities.Add(swimmingActivity);

        Console.WriteLine("summary:");
        Console.WriteLine("\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}