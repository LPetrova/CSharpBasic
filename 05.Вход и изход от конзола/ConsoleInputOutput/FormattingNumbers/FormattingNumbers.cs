﻿//Problem 5.	Formatting Numbers
//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
//Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, 
//padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal 
//point, left aligned. Examples:

using System;
using System.Text;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        if (0 <= a && a <= 500)
        {
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            string abit = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("|{0,-10:X}|{3}|{1,10:N2}|{2,-10:F3}|", a, b, c, abit);

        }

    }
}

