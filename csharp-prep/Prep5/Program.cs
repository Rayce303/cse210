using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        return num;
    }

    static void PromptUserBirthYear(out int year)
        {
            Console.Write("Please enter the year you were born: ");
            string input = Console.ReadLine();
            year = int.Parse(input);
        }

    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult(string name, int year, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
        int age = 2026 - year;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year;
        PromptUserBirthYear(out year);
        int square = SquareNumber(number);
        DisplayResult(name, year, square);
    }
}