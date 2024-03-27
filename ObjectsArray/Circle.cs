using System;

namespace shapes;

// Circle class
public class Circle : IShape
{	
	// Class variable
	double radius;

	// Constructor
	public Circle (double radius)
	{
		this.radius = radius;
	}

	// Method to calculate area
	public double CalculatedArea()
	{
		return (3.14 * radius * radius);
	}

    // Method to calculate perimeter
    public double CalculatedPerimeter()
    {
       return (2 * 3.14 * radius);
    }
}
