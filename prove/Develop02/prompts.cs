using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Prompt
    {   // a list of prompts to give the user
        public List<string> promptsList = new List<string>()
        {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        };

        // picks a random prompt from the above list
        public string GetRandPrompt()
        {
            Random rand = new Random();
            int randNum = rand.Next(promptsList.Count); 
            return promptsList[randNum];
        }
    }
}