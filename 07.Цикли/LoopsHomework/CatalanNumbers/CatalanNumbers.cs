//Problem 8.	Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula:
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:

using System;
using System.Numerics;


class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if (0 <= n && n < 100)
        {
            BigInteger multiFactorielN = 1;
            BigInteger plusFactoriel = 1;
            BigInteger factorielN = 1;
            BigInteger result = 0;

            for (int i = 1; i <= 2*n; i++)
            {
                multiFactorielN *= i;
            }

            for (int j = 1; j <= n + 1; j++)
            {
                plusFactoriel *= j;
            }

            for (int k = 1; k <= n; k++)
            {
                factorielN *= k;
            }

            result = multiFactorielN / (plusFactoriel * factorielN);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

