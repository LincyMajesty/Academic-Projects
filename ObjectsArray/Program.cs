using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace shapes;

public class Program
{
    public static void Main(string[] args)
    {   // Array shapes of type IShape
        IShape[] shapes = new IShape[4];

        shapes[0] = new Rectangle(8, 4);
        shapes[1] = new Rectangle(6, 2);
        shapes[2] = new Circle(7);
        shapes[3] = new Circle(3);

        // Printing the calculated areas & perimeters of the shapes
        foreach (IShape shape in shapes)
        {
            Console.WriteLine("Area: " + System.Math.Round(shape.CalculatedArea(), 2));
            Console.WriteLine("Perimeter: " + System.Math.Round(shape.CalculatedPerimeter(), 2));
        }
    }
}
