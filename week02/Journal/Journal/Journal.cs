    using System;
    using System.Collections.Concurrent;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
namespace MyProject;

    
    public class Journal{
    //make up list of users notices(classes Entry)
    public List<Entry>_notices=new List<Entry>();//make list for our notices
        public void AddNotices(Entry entry)
        {
            _notices.Add(entry);
        }
        public void OutputData()
        {
        foreach (Entry entry in _notices)
        {
         Console.WriteLine(entry.ToString());//output from list notices
        }
                
        }
        public void SaveInFile(string filename){
            if(!filename.EndsWith(".csv")) // ______Creativity extension - add .csv ,to be able open it in Excel
            filename+=".csv";

                      
        { 
                        
            using (StreamWriter writer = new StreamWriter(filename)) 
        { 
            foreach (Entry entry in _notices) 
        { 
            writer.WriteLine($"{entry._date},{entry._prompt},{entry._usersNotice}"); } //make file and save there
                        
        }
        Console.WriteLine($"\n it was saved in file: {Path.GetFullPath(filename)}\n");//assurance
        SaveJson(Path.ChangeExtension(filename,".json"));//______Creativity:call method for json saving
        }
    }

        

        public void SaveJson(string filename){// ______Creativity :method for JSON saving
            string jsonContent = "[\n";
    

        for (int i = 0; i < _notices.Count; i++)
         {
        Entry entry = _notices[i];
        
        //make all entries to JSON 
        jsonContent += "  {\n";
        jsonContent += $"    \"date\": \"{entry._date}\",\n";
        jsonContent += $"    \"prompt\": \"{entry._prompt.Replace("\"", "\\\"")}\",\n";
        jsonContent += $"    \"entry\": \"{entry._usersNotice.Replace("\"", "\\\"")}\"\n";
        jsonContent += "  }";
        
        // запятые
        if (i < _notices.Count - 1)
            jsonContent += ",";
            
        jsonContent += "\n";
    }
    
         //закрываем массив(?)
           jsonContent += "]";


        
        File.WriteAllText(filename,jsonContent);
        System.Console.WriteLine($"it was saved json-{Path.GetFullPath(filename)}");
    }

    

    






            
            


        public void LoadFromFile(string filename)//load from file
        {


        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            DateTime date = DateTime.ParseExact(parts[0], "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string promptLoad = parts[1];
            string noticeLoad = parts[2];

            Console.WriteLine($"date: {date}, prompt: {promptLoad}, notice: {noticeLoad}");
        }
    }
        }
    
                    

                    
                
            
    

        


            






            

            




        
        

    