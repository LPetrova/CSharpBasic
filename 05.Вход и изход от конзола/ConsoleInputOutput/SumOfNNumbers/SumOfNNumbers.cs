//Problem 9.	Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. Examples:

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a numbers: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The result is: " + sum);
    }
}

