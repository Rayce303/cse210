using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = 1;

        while (input != 0)
        {
            Console.Write("Enter a number: ");
            string text = Console.ReadLine();
            input = int.Parse(text);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int total = 0;
        int largestNum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];

            if (numbers[i] > largestNum)
            {
                largestNum = numbers[i];
            }
        }

        double average = total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}