
//Problem 1.	Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum. Examples:


using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("a= ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double num3 = double.Parse(Console.ReadLine());

        double sum = num1 + num2 + num3;
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}", num1, num2, num3, sum);
    }
}

