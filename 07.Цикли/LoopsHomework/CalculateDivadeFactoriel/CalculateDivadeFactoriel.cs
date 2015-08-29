//Problem 6.	Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:

using System;

class CalculateDivadeFactoriel
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers n and k in range (1 < k < n < 100): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorielK = 1;
        int factorielN = 1;

        if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
            if (k >= i)
            {
                factorielK *= i;
            }
        }
        Console.WriteLine("{0}", factorielN/factorielK);


    }
}

