using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myThingy = new Assignment("Phteven", "Paranormal Studies");
        Console.WriteLine(myThingy.GetSummary());

        MathAssignment yayMath = new MathAssignment("Brichard", "Calculus", "9", "12-20");
        Console.WriteLine(yayMath.GetHomeworkList());

        WritingAssignment writeyTighty = new WritingAssignment("Throckmorton", "Wumbology", "The Study of Wumbo");
        Console.WriteLine(writeyTighty.GetWritingInfo());
    }
}