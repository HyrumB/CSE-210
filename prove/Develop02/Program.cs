using System;
using System.Collections.Generic;

namespace Develop02{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHandleing consoleHandleing = new ConsoleHandleing();

            DateTime currentTime = DateTime.Now;
            //string dateText = currentTime.ToShortDateString();

            Prompt prompt = new Prompt();
            //string userPrompt = prompt.GetRandPrompt();

            //Entry myEntry = new Entry();
            //myEntry.Store(userPrompt, consoleHandleing.GetEntry(userPrompt), dateText);

            Journal journal = new Journal();
            //journal.StoreEntry(myEntry);

            FileManaging fileManaging = new FileManaging();
            //fileManaging.saveToFile(consoleHandleing, myEntry, journal);
            //fileManaging.LoadFromFile(consoleHandleing, myEntry);

            Menu menu = new Menu();
            menu.userMenu(consoleHandleing, currentTime, prompt, journal, fileManaging );

            

        }
    }
}