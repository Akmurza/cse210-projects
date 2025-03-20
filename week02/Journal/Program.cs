using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using MyProject;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("Hello World! This is the Journal Project.");
    Journal journal =new Journal();//make up instance of our Input-Output class Journal


       while(true){//ethernal cycle
            //display menu
            Console.Write("Insert the number of request: \n 1.write some new notice \n 2.display all notices \n 3.save in file \n 4.load from file \n 5.want to quit \n");
            string usersAnswer = Console.ReadLine(); //read users number 
            int usersAnswerInt = int.Parse(usersAnswer);//and convert it in integer
            //handling users answers
            if(usersAnswerInt==1)
            {
                string randomPromptOutput=PromptGenerator.Prompt();//call prompt func from prompt class,but it might be just method
                System.Console.WriteLine(randomPromptOutput);
                string usersNotice = Console.ReadLine();//read users notice
                DateTime now =DateTime.Now;
                Entry entry=new Entry(now,randomPromptOutput,usersNotice);
                journal.AddNotices(entry);//call method to save it in List in class Entry

            }
            else if(usersAnswerInt==2)
            {
                journal.OutputData();//call output method
                
            }
            else if(usersAnswerInt==3)

            {
                System.Console.WriteLine("insert file name");
                string nameFile = Console.ReadLine();
                journal.SaveInFile(nameFile);
        

            }
            else if(usersAnswerInt==4)
            {
                Console.WriteLine("insert file name");
                string readUsersFileName = Console.ReadLine();
                journal.LoadFromFile(readUsersFileName);

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