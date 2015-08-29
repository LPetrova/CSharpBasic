//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, 
//without repeating numbers, and arranged in increasing order. 
//The input and output lists are given as integers, separated by a space, each list at a separate line. Examples:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            Console.Write("Enter first list of integer numbers: ");
            string first = Console.ReadLine();
            var firstNumbers = Array.ConvertAll(first.Split(' '), int.Parse).ToList();

            Console.Write("Enter second list of integer numbers");
            string second = Console.ReadLine();
            var secondNumbers = Array.ConvertAll(second.Split(' '), int.Parse).ToList();

            firstNumbers.AddRange(secondNumbers);

            firstNumbers.Sort();
            for (int i = 0; i < firstNumbers.Count; i++)
            {
                if (i == firstNumbers.Count - 1)
                {
                    break;
                }
                else
                {
                    if (firstNumbers[i] == firstNumbers [i + 1])
                    {
                        firstNumbers.RemoveAt(i);
                        i--;
                    }
                }
            }
            foreach (var item in firstNumbers)
            {
                Console.WriteLine(item + " ");   
            }
            Console.WriteLine();
        }
    }
}
