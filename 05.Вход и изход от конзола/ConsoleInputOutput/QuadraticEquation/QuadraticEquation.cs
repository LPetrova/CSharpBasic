//Problem 6.	Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "ax2 + bx + c = 0";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double diskriminant = b * b - 4 * a * c;

        if (diskriminant < 0)
        {
            Console.WriteLine(" Quadratic equation don't have real roots.");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}   x2 = {1}", x1, x2);
        }




    }
}

