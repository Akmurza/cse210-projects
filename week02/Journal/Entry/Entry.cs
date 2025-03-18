using System;
using System.ComponentModel;
using System.Diagnostics;
namespace MyProject;

public class Entry{
    public List<string>_notices=new List<string>();
    public void EntryData(string notice)
    {
        _notices.Add(notice);
    }
    public void OutputData()
    {
        foreach (string notice in _notices){
            Console.WriteLine(notice);
        }
    
    }
    public void SaveInFile()
    {
        Console.WriteLine("insert name of file");
        string nameFile=Console.ReadLine();
        File.WriteAllLines(nameFile,_notices);

    }
    public void LoadFromFile(string nameFile)
    { 
        if(File.Exists(nameFile))
        {
            _notices= new List<string>(File.ReadAllLines(nameFile));
            System.Console.WriteLine("file downloaded");

        }
        else
        {
            Console.WriteLine("not found");

        }


    }
    

}