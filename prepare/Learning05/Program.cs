using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _theListyList = new List<Shape>();

        Square mcSquare = new Square("red", 2.0);
        Rectangle oofboof = new Rectangle("yellow", 3.2, 5.6);
        Circle fweefwee = new Circle("gray", 30.12);
        
        _theListyList.Add(mcSquare);
        _theListyList.Add(oofboof);
        _theListyList.Add(fweefwee);

        foreach(Shape index in _theListyList)
        {
            Console.WriteLine(index.GetColor());
            Console.WriteLine(index.GetArea());
        }
    }
}