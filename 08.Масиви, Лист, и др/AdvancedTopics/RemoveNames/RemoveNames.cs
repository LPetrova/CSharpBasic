//Problem 5.	Remove Names
//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
//The input and output lists are given as words, separated by a space, each list at a separate line. Examples:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            Console.Write("Enter first list: ");
            string namesList = Console.ReadLine();
            Console.Write("Enter second list: ");
            string replacedList = Console.ReadLine();

            List<string> firstList = new List<string>(namesList.Split());
            List<string> secondList = new List<string>(replacedList.Split());

            foreach (var item in secondList)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (item == firstList[i])
                    {
                        firstList.RemoveAt(i); 
                        i--;
                    }
                }
            }
            foreach (var item in firstList)
            {
                Console.WriteLine( item + " "); 
            }
            Console.WriteLine();

        }
    }
}
