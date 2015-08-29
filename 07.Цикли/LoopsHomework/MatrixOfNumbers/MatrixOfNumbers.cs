//Problem 9.	Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. Examples:

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n + i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }          
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

