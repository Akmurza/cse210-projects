using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
namespace MyProj;


//*as creativity I added one letter mode, which expands the capabilities of our program and allows you to switch to a special mode at any time by pressing the L key, in which we will not only hide the word, but the program will leave one of the random letters as a hint. I simply represented the word as an array of 
// char and implemented the logic added in the word class, adding a couple more conditions in the body of the program in the Scripture class
//  and main in Program


//i implemented hiding of not only random words,but specifically those words that was not hidden yet! 
//i have done it using the IsHidden flag in the word class and a loop that checks whether the word is hidden(noticed it in commets of class)
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
        bool revealOneLetterMode=false;//default value for new mode


        //if user dont insert QUIT or until all words hidden flag havent appear- there works while cycle
        while (userInput.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();//clear all console every time again
            Console.WriteLine(scripture.GetDisplayText(revealOneLetterMode));//shows partly hidden text from scripture class's by method___!!!
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue play or 'quit' to quit, or if you want to try one letter extended mode press l and then Enter:");
            userInput = Console.ReadLine();
            // subs random words if user plays
            if (userInput.ToLower()=="l")
            {
                revealOneLetterMode=true;// creativity option
    
            }
            
            else if (userInput != "quit")
            scripture.HideRandomWords(2,revealOneLetterMode); // Hide 2 words at a time by method_!!!
        }
        // show the final scripture if all are hidden
        if (scripture.AllWordsHidden())                    //method _!!!
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText(revealOneLetterMode));// method_!!!
            Console.WriteLine();
            Console.WriteLine("All words is hidden. Well done!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}