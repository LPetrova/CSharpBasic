
//Problem 12.	Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p. Examples:

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        int numRight = number >> index;
        int mask = 1;
        int result = numRight & mask;
        Console.WriteLine("Binay representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("The result is --> {0}", result);
    }
}

