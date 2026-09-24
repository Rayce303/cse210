using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = new Random().Next(1, 101);
        int intGuess;

        do
        {
            Console.Write("What's your guess? ");
            string guess = Console.ReadLine();
            intGuess = int.Parse(guess);

            if (intGuess == magicNumber)
            {
                Console.WriteLine("That's it!");
            }
            else if (intGuess > magicNumber)
            {
                Console.WriteLine("Too high.");
            }
            else if (intGuess < magicNumber)
            {
                Console.WriteLine("Too low.");
            }
        } while (intGuess != magicNumber);
    }
}