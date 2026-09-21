using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;

        if (grade <= 100 && grade >= 90)
        {
            letter = "A";
        }
        else if (grade <= 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade <= 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade <= 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Yay! You passed!");
        }
        else
        {
            Console.WriteLine("Oh no, do better next time!");
        }
    }
}