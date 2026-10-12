
class Program
{
    static void Main()
    {
        Console.WriteLine("Hey, sup dude.");

        Circle myCircle = new Circle(16);

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}