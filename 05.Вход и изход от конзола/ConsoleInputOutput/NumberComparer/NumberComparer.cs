﻿
//Problem 4.	Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. Examples

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a > b ? "The grater is: {0}" : "The grater is: {1}", a, b);
        
    }
}

