//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
        {
            Console.Title = "Point in a Circle";
            Console.WriteLine("Enter two numbers coordinates of a point:");
            Console.Write("x--->");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y--->");
            int y = int.Parse(Console.ReadLine());
           
            Console.Write("Point is in the circle! --> ");

            bool pointInCircle = Math.Sqrt(x * x + y * y) <= 2 ;
            Console.WriteLine(pointInCircle);
        }
}

