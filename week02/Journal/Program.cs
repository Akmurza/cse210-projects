using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using MyProject;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("Hello World! This is the Journal Project.");
    Entry entry=new Entry();//make up instance of our Input-Output class Entry


       while(true){//ethernal cycle
            //display menu
            Console.Write("Insert the number of request: \n 1.write some new notice \n 2.display all notices \n 3.save in file \n 4.load from file \n 5.want to quit \n");
            string usersAnswer = Console.ReadLine(); //read users number 
            int usersAnswerInt = int.Parse(usersAnswer);//and convert it in integer
            //handling users answers
            if(usersAnswerInt==1)
            {
                PromptGenerator.Prompt();//call prompt func from prompt class,but it might be just method
                string usersNotice = Console.ReadLine();//read users notice
                entry.EntryData(usersNotice);//call method to save it in List in class Entry

            }
            else if(usersAnswerInt==2)
            {
                entry.OutputData();//call output method
                
            }
            else if(usersAnswerInt==3)
            {
                entry.SaveInFile();
        

            }
            else if(usersAnswerInt==4)
            {
                Console.WriteLine("insert file name");
                string readUsersFileName = Console.ReadLine();
                entry.LoadFromFile(readUsersFileName);

            }
            else if(usersAnswerInt==5)
            {
                Console.WriteLine("ok go out of here");
                break;//the end of the programm

            }
            else
            {
                Console.WriteLine("insert please correct number");
            }
       }    

    }
}