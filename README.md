SHAPE AREA & PERIMETER CALCULATOR
This C# program demonstrates the use of interfaces, inheritance, and object arrays to calculate the area and perimeter of rectangles and circles.

How to Run
To run the program, follow these steps:
1. Open the solution file Project1.sln in Visual Studio.
2. Build the solution to ensure all dependencies are resolved.
3. Run the program by pressing F5 or clicking on the "Start" button in Visual Studio.

Overview
This program defines an interface called IShape with methods to calculate the area and perimeter of shapes. Two classes, Rectangle and Circle, implement this interface to represent rectangles and circles, respectively.

IShape Interface
The IShape interface defines the following methods:
• CalculateArea(): Calculates the area of the shape and returns a double.
• CalculatePerimeter(): Calculates the perimeter of the shape and returns a double.

Rectangle Class
The Rectangle class represents rectangles and implements the IShape interface. It has the following features:
• Private fields length and width to store the dimensions of the rectangle.
• A constructor to initialize the length and width.
• Implementation of CalculateArea() to compute the area of the rectangle (length * width).
• Implementation of CalculatePerimeter() to compute the perimeter of the rectangle (2 * (length + width)).

Circle Class
• The Circle class represents circles and also implements the IShape interface. It includes:
• A private field radius to store the radius of the circle.
• A constructor to initialize the radius.
• Implementation of CalculateArea() to compute the area of the circle (π * radius^2).
• Implementation of CalculatePerimeter() to compute the circumference of the circle (2 * π * radius).

Main Method
In the Main method:
• An array of IShape interface references called shapes is created.
• At least two Rectangle objects and two Circle objects are instantiated.
• These objects are assigned to the shapes array.
• The program iterates through the shapes array and prints out the area and perimeter of each shape.

By running this program, you will see the proper use of interfaces, inheritance, and object arrays to calculate the area and perimeter of shapes. Enjoy exploring the code and experimenting with different shapes!
