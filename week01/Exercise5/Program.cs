using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string usersName = PromptUserName();
        string userNumber = PromptUserNumber();
        int number = int.Parse(userNumber);

        int squaredNumber = SquareNumber(number);

        DisplayResult(usersName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome!!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?");
        string someName = Console.ReadLine();
        return someName;
    }
    static string PromptUserNumber()
    {
        Console.Write("your favorite number?");
        string number=Console.ReadLine();
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"dear {name}, the square of u number = {square}, i hope it will help you");
    }


}