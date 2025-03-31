using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
namespace MyProj;

class Program
{
    static void Main(string[] args)
    {
        //make reference instance
        Reference reference = new Reference("John", 3, 16);//_class!!!
        //make text 
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        //make scripture + reference+ text instance ,we can extend it and add more scriptures even array and select any by Random method
        Scripture scripture = new Scripture(reference, scriptureText);// class_!!!
        //main while loop
        string userInput = "";
        //if user dont insert QUIT or until all words hidden flag havent appear- there works while cycle
        while (userInput.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();//clear all console every time again
            Console.WriteLine(scripture.GetDisplayText());//shows partly hidden text from scripture class's by method___!!!
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue play or 'quit' to quit:");
            userInput = Console.ReadLine();
            // subs random words if user plays
            if (userInput != "quit")
            scripture.HideRandomWords(2); // Hide 2 words at a time by method_!!!
        }
        // show the final scripture if all are hidden
        if (scripture.AllWordsHidden())                    //method _!!!
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());// method_!!!
            Console.WriteLine();
            Console.WriteLine("All words is hidden. Well done!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}