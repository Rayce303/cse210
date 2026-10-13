using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction theFraction = new Fraction();
        Random rand = new Random();

        for (int i = 0; i < 20; ++i)
        {
            int randomTop = rand.Next(1, 101);
            int randomBottom = rand.Next(1, 101);

            theFraction.SetTop(randomTop);
            theFraction.SetBottom(randomBottom);

            Console.WriteLine($"Fraction {i + 1} - String: {theFraction.GetFractionString()}, Decimal: {theFraction.GetDecimalValue()}");
        }
        
    }
}