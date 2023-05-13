using System;
using System.Collections.Generic;


namespace Develop02
{
    public class ConsoleHandleing
    {
        //prompt user for an journal entry and outputs their prompt
        public string  GetEntry(string userPrompt){
            Console.Write($"{userPrompt} \n>");
        string userInput = Console.ReadLine();
        return userInput;
        }

        // collects file name input
        public string  GetFileName(){
            Console.Write($"input file name \n>");
        string userInput = Console.ReadLine();
        return userInput;
        }

         public string  GetMenuInput(){
            Console.WriteLine("input one of the following options (1,2,3,4,5)");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write($"what would you like to do? \n>");
        string userInput = Console.ReadLine();
        return userInput;
        }
        // displays the contents of the Journal class's list called entries
        public void displayJournal(Journal journal){

            //Entry index = new Entry();
            
            List<Entry> entries;
            entries = journal.GetAllEntries();
            foreach (Entry index in entries){

                Console.WriteLine(index.getFormatedString());

                //Console.WriteLine(entries.Count);//debugging
            }
        }

    }
}
