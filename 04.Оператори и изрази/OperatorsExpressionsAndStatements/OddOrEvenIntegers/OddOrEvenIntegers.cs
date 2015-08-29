
//Problem 1.	Odd or Even Integers
//Write an expression that checks if given integer is odd or even. Examples:

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Title = "Odd or Even Enteger";
        Console.WriteLine("Please enter the integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = true;
        string integer = " ";

        if (number % 2 !=0)
        {
            integer = "odd";
        }
        else
        {
           integer  = "even";
        }


        Console.WriteLine("The number {0} is {1}.", number, integer);
    }
}

