//Problem 7.	Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. Examples:


using System;

 class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enters 5 numbers (given in a single line, separated by a space)");
            string numbers = Console.ReadLine();
            string[] fiveNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int n = 0; n < fiveNumbers.Length; n++)
            {
                sum += double.Parse(fiveNumbers[n]);
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }

