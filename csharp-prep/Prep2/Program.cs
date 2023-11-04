using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeString = Console.ReadLine();
    
        int gradeInt = int.Parse(gradeString);

        string letter;

        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else if (gradeInt < 50)
        {
            letter = "F";
        }
        else 
        {
            letter = "invalid option";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else 
        {
            Console.WriteLine("You did not pass.");
        }
    }
}