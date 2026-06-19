using System;
using System.Collections.Generic;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Square mySquare = new Square("Red", 5.0);
            shapes.Add(mySquare);

            Rectangle myRectangle = new Rectangle("Blue", 4.0, 6.0);
            shapes.Add(myRectangle);

            Circle myCircle = new Circle("Green", 3.0);
            shapes.Add(myCircle);

            Console.WriteLine("--- Shape Portfolio ---");
            foreach (Shape shape in shapes)
            {
                string color = shape.GetColor();
                double area = shape.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area:F2}.");
            }
        }
    }
}