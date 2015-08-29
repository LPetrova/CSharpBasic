//Problem 3.	Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples:

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter;
        double area;

        perimeter = Math.PI * 2 * radius;
        area = Math.PI * (radius * radius);
        Console.WriteLine("The perimeter is: {0:F2}", perimeter);
        Console.WriteLine("The area is: {0:F2}", area);
    }
}

