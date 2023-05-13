using System;

class Program
{
    static void Main(string[] args)
    {
    int magicNum = 4;


    // prints to console
    Console.WriteLine("What is your guess? ");
    //takes user input
    string userGuess = Console.ReadLine();

    int userNum = int.Parse(userGuess);

    while (userNum != magicNum)
        if (userNum > magicNum)
        {
            Console.WriteLine("too high");
        }
        
        else if (userNum < magicNum)
        {
            Console.WriteLine("too low");
        }





    }
}