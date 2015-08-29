
//Problem 13.	* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant 

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first floating point number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second floating point number: ");
        double b = double.Parse(Console.ReadLine());

        bool equal = Math.Abs(a - b) < 0.000001;

        Console.WriteLine("{0} == {1} ---> {2}", a, b, equal);
    }
}

