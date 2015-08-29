//Problem 1.	Sorting Numbers
//Write a program that reads a num n and a sequence of n integers, sorts them and prints them. Examples:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Next num = ");
            int anotherNum = int.Parse(Console.ReadLine());
            numbers[i] = anotherNum;
        }
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}

