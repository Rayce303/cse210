using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal myGoal = new SimpleGoal();
        Console.WriteLine(myGoal.GetConsoleString());
        myGoal.RecordEvent();
        Console.WriteLine(myGoal.GetConsoleString());
    }
}