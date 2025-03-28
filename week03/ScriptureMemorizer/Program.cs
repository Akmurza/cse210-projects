using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
namespace MyProj;

using System;

class Program
{
    static void Main(string[] args)
    {
        //make reference
        Reference reference = new Reference("John", 3, 16);

        //make text 
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        
        // make scripture + reference+ text
        Scripture scripture = new Scripture(reference, scriptureText);
        
            //main while loop
            string userInput = "";
            while (userInput.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            //clear all
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue play or 'quit' to quit:");
            
            
            userInput = Console.ReadLine();
                // subs random words if user plays
            if (userInput !=  "quit")
                scripture.HideRandomWords(2); // Hide 2 words at a time
            
        }
        
    // show the final scripture if all are hidden
        if (scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words is hidden. Well done!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}