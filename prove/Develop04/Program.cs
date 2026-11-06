using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathe = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity list = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

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
                    reflect.RunActivity();
                    break;
                case "3":
                    list.RunActivity();
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