//Problem 10.	Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. Examples:

using System;

class FibonacciNumbers
{

    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int fibN;

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}", a);
            fibN = a + b;
            a = b;
            b = fibN;

        }
    }
}

