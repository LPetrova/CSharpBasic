
//Problem 12.	Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmeti
    {
        static void Main()
        {
            int? integer = null;
            double? dvariable = null;

            Console.WriteLine("Integer with variable Null is: " + integer);
            Console.WriteLine("Double with variable Null is: " + dvariable);

            int integerNum = 14;
            double doubleNum = 14.4;

            Console.WriteLine("Add integer variable is: " + integerNum);
            Console.WriteLine("Add double variable is: " + doubleNum);
        }
    }

