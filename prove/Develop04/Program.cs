using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathe = new BreathingActivity("Breathing Activity", "In a few seconds, you will go through a breathing exercise.");
        // ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", );

        string userInput = "";

        while (userInput != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Which activity sounds so dang fun to you?");
            Console.WriteLine("[1] - Breathing Activity");
            Console.WriteLine("[2] - Reflection Activity");
            Console.WriteLine("[3] - Listing Activity");
            Console.WriteLine("[4] - Quitting");

            userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    breathe.RunActivity();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Okay, see ya around.");
                    break;
                default:
                    break;
            }
        }
    }
}