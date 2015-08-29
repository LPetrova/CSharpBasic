//Problem 7.	Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose l different members out of a group of n different elements (also known as the number of combinations) 
//is calculated by the following formula:
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (l! * (n-l)!) 
//for given n and l (1 < l < n < 100). Try to use loops. Examples:

using System;
using System.Numerics;
class CalculateN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("l = ");
        int k = int.Parse(Console.ReadLine());
        if (n > 1 && n > 1 && n < 100 && k < 100)
        {
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger factorielNAndK = 1;
            BigInteger result = 0;
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factorielK *= j;
            }
            for (int l = 1; l <= (n- k) ; l++)
            {
                factorielNAndK *= l;
            }
            result = factorielN / (factorielK * factorielNAndK);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

