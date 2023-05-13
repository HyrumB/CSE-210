using System;
using System.IO;
using System.Collections.Generic;

namespace Develop02
{
    public class FileManaging
    {

            // adds entry to file collected from input
        public void saveToFile(ConsoleHandleing consoleHandleing, Journal journal)
        {

        string fileName = consoleHandleing.GetFileName();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                List<Entry> entries = journal.GetAllEntries();
                foreach(Entry entry in entries)
                {
                    string message = entry.GetAsString();
                    outputFile.WriteLine(message);
                }    
            }
        } 
        
        // pulls all entrys from inputed file
        public void LoadFromFile(ConsoleHandleing consoleHandleing, Journal journal)
        {
            string fileName = consoleHandleing.GetFileName();

            string fileLines = "";
            string[] lines;
            char[] seperators = new char[] {':', '-'};

                // pulls string from text file
                lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {   
                        fileLines += line;
                        //this seperates the string withing the variable
                        string[] seperate = fileLines.Split(seperators);

                        string dateTime = seperate[0];
                        string oldUserInput = seperate[2];
                        string userPrompt = seperate[1];
                        
                        //Console.WriteLine($"seperate{seperate.Length}");//debugging
                        
                        Entry userEntry = new Entry();
                        userEntry.Store(userPrompt, oldUserInput, dateTime);
                        journal.StoreEntry(userEntry);
                        
                        fileLines ="";
                    }

        }
    }
}
