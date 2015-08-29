
//Problem 4.	Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height. 

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int perimeter = (a + b) * 2;
        Console.WriteLine("The perimeter is:");
        Console.WriteLine(perimeter);

        int area = a * b;
        Console.WriteLine("The area is: ");
        Console.WriteLine(area);
    }
}

