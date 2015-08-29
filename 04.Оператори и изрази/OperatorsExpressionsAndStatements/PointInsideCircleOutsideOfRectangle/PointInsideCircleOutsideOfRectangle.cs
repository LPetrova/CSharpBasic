﻿
//Problem 10.	Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;

    class PointInsideCircleOutsideOfRectangle
    {
        static void Main()
        {
            Console.Title = "Point Inside a Circle & Outside of a Rectangle";
            Console.WriteLine("Enter two numbers: ");
            Console.Write("x--->");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y--->");
            double y = double.Parse(Console.ReadLine());
            
            bool pointInCircle = Math.Sqrt((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5;
            bool isOutsideRectangle = (x <= 5 || x >= -1) || (y <= 1 || y >= -1);
            
            if (pointInCircle && isOutsideRectangle)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

