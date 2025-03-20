    using System;
    using System.Collections.Concurrent;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Security.Cryptography.X509Certificates;
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
                      
        { 
                        
                using (StreamWriter writer = new StreamWriter(filename)) 
        { 
            foreach (Entry entry in _notices) 
        { 
            writer.WriteLine($"{entry._date},{entry._prompt},{entry._usersNotice}"); } //make file and save there
                        
        }
        Console.WriteLine($"\n notices was saves in file: {Path.GetFullPath(filename)}\n");//assurance
        }
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
    
                    

                    
                
            
    

        


            






            

            




        
        

    