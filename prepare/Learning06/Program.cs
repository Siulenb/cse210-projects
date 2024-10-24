using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");


        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 5);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("green", 5, 2);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Red", 6);
        shapes.Add(shape3);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();

            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {Math.Round(area,2)}.");


        }

    }
}