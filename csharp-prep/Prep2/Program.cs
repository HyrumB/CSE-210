using System;

class Program
{
    static void Main(string[] args)
    {
    // prints to console
    Console.WriteLine("what is your grade percent");
    //takes user input
    string gradeString = Console.ReadLine();

    int gradePercent = int.Parse(gradeString);
    Boolean passFail = false;
    string letterGrade = " ";
    /* 
    A >= 90
    B >= 80
    C >= 70
    D >= 60
    F < 60 
    */

    if(gradePercent >= 90)
    {
        letterGrade = "A";
        passFail = true;
    }
    else if(gradePercent >= 80)
    {
        letterGrade = "b";
        passFail = true;
    }
    else if(gradePercent >= 70)
    {
        letterGrade = "C";
        passFail = true;
    }
    else if(gradePercent >= 60)
    {
        letterGrade = "D";
        passFail = false;
    }
    else
    {
        letterGrade = "F";
        passFail = false;
    }

    Console.WriteLine($"your grade is {letterGrade} ");

    if(passFail)
    {
        Console.WriteLine("you passed great job!");
    }

    else if(!passFail)
    {
        Console.WriteLine("you Failed but keep your chin up and ");
        /* this is an exerpt from a poem by dylan thomas */
        Console.WriteLine("have an exerpt from Dylan Thomas");
        Console.WriteLine("Do not go gentle into that good night. Rage, rage against the dying of the light. ");    
    }

    }
}