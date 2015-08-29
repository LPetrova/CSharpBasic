//Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. Examples:

using System;

class IntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double p = 0;  //counter

        for (int i = a; i <= b; i++) 
        {
            if (i % 5 == 0)
            {
                p++;
                Console.WriteLine("{0}", i);
            }
        }
        Console.WriteLine("Positive integer numbers between {0} and {1}, that the reminder of their division  by 5 is 0 are:  {2}", a, b, p );
    }
}


