﻿//Problem 1.	Exchange If Greater
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space. 

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("a = {0} and b = {1}", b, a);
        }
        Console.WriteLine("a = {0} and b = {1}", a, b);
    }
}

