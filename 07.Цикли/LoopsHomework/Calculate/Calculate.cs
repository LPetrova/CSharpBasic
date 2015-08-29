//Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
//Print the result with 5 digits after the decimal point.

using System;

class Calculate
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factoriel = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += (factoriel/Math.Pow(x, i));
        }
        Console.WriteLine("{0:f5}", sum);
    }
}

