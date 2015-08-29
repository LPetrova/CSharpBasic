//Problem 3.	Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of i integer numbers and returns the minimal, the maximal i, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point). The input starts by the i i (alone in a line) followed by i lines, each holding an integer i. 
//The output is like in the examples below. Examples:

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int minValue = int.MinValue;
        int maxValue = int.MaxValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
            if (array [i] < maxValue)
            {
                maxValue = array[i];
            }
            
            if (array[i] > minValue)
            {
                minValue = array[i];
            }
        }
        double average = (double)sum / n;
        Console.WriteLine("Max = " + maxValue);
        Console.WriteLine("Min = " +minValue);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("The average is: {0:f2}", average);

    }
}

