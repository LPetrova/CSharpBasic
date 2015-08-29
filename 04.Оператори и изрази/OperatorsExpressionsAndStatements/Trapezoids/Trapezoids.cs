//Problem 9.	Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Title = "Trapezoid's area";
        Console.WriteLine("Please, enter the sides a and b and height h. ");
        Console.Write("a--->");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b--->");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h--->");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;
        Console.WriteLine("The trapecoid's area is --> " + area);


    }
}

