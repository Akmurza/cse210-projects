using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your rating?");
        string rating = Console.ReadLine();
        int rate = int.Parse(rating);
        string letter="";
        if(rate>=90)
        {
            letter="A";
        }
        else if(rate>=80)
        {
            letter="B";
        }
        else if(rate>=70)
        {
            letter="c";
        }
        else if(rate>=60)
        {
            letter="D";
        }
        else if (rate<60)
        {
            letter="F";
        }
        Console.WriteLine($"then your grade is {letter}");
        if(rate>=70)
        Console.WriteLine("Congrats!");
        else 
        Console.WriteLine("here must be motivational speech for you!Try again you will get it!");
    }
    
}