
//Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7. 


using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberdivadeToHundret = number / 100;
        int thirdDigit = Math.Abs(numberdivadeToHundret % 10);
        bool isThirdDigit = thirdDigit == 7;
        Console.WriteLine(isThirdDigit);
        
    }
}

