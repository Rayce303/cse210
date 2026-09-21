using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 8;
        int y = 14;
        int z = 40;

        if (x == 10 && y == 12 || z == 40)
        {
            Console.WriteLine("X is 10");
            Console.WriteLine("waffle");
        }
        else if (x == 20)
        {
            Console.WriteLine("Rawr");
        }
        else
        {
            Console.WriteLine("sneep snoop");
        }
    }
}