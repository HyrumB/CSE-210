using System;

namespace Develop02
{
    public class Menu
    {
        string userInput = "";
        int userInputInt = 0;
        

        public void userMenu(ConsoleHandleing consoleHandleing, DateTime currentTime, Prompt prompt, Journal journal, FileManaging fileManaging ){

            while (userInput != "5"){
            userInput = consoleHandleing.GetMenuInput();
            //turns input to an integer
            userInputInt = int.Parse(userInput);

            string userPrompt = prompt.GetRandPrompt();
            string dateText = currentTime.ToShortDateString();

            switch(userInputInt)
            {
            case 1:
                Entry userEntry = new Entry();
                userEntry.Store(userPrompt, consoleHandleing.GetEntry(userPrompt), dateText);
                journal.StoreEntry(userEntry);
                break;

            
            case 2:
                consoleHandleing.displayJournal(journal);
                break;
            
            case 3:
                fileManaging.LoadFromFile(consoleHandleing, journal);
                break;

            case 4:
                fileManaging.saveToFile(consoleHandleing, journal);
                break;

            case 5:
                break;
            
            }


            }

        }
    }
    }