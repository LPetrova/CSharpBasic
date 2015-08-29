//Problem 1.	Numbers from 1 to N
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}

