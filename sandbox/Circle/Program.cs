
class Program
{
    static void Main()
    {
        Console.WriteLine("Hey, sup dude.");

        Circle myCircle = new Circle();
        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}