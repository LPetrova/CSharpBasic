
//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {

        Console.Title = "Prime Number Check";
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        if (0 < n && n <= 100)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);

        }
        else
        {
            Console.WriteLine("The number must be positive! ");
        }
    }

}

