using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Green",4);

        Rectangle r1 = new Rectangle("Red", 4, 8);

        Circle c1 = new Circle("Yellow",4);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape sh in shapes)
        {
            Console.WriteLine($"The {sh.GetColor()} shape has an area of {sh.GetArea()}.");
        }

    }
}