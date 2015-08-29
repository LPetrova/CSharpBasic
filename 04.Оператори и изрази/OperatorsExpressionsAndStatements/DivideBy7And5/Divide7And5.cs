
//Problem 3.	Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

  class Divide7And5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool booleanExpression = (number % 5 == 0) && (number % 7 ==0);
            Console.WriteLine(booleanExpression);

        }
    }

