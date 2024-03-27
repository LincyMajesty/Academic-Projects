using System;
using System.ComponentModel.DataAnnotations;

namespace shapes;

// IShape Interface
interface IShape
{
    // Interface variables
	double CalculatedArea();
    double CalculatedPerimeter();
}

// Rectangle class
public class Rectangle : IShape
{
    // Class variables
    protected double length;
    public double width;

    // Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Method to calculate area
    public double CalculatedArea()
    {
        return length * width;
    }

    // Method to calculate perimeter
    public double CalculatedPerimeter()
    {
        return 2 * (length + width);
    }
}
