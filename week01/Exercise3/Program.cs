using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new();
        int number = randomGenerator.Next(1,5);

        int usersGuess=1;

        while(usersGuess!=number)
        {
            Console.WriteLine("insert any number from 1 to 5");
            usersGuess = int.Parse(Console.ReadLine());
            if(number>usersGuess)
            {
                Console.WriteLine("more");
            }
            else if(number<usersGuess)
            {
                Console.WriteLine("less");
            }
            else{
            Console.WriteLine("congrats! your insight is magical");

            }
        }

    }
}


