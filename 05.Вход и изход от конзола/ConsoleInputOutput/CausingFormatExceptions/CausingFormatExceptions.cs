
//Problem 2.	Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class CausingFormatExceptions
{
    static void Main()
    {
        Console.Write("Name company: ");
        string nameCom = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: 00359 ");
        int phoneNum = int.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        string faxNum = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lasttName = Console.ReadLine();
        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager  phone number: 00359 ");
        int phoneNumManager = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------", 30);

        Console.ForegroundColor = ConsoleColor.DarkGray;
        
        Console.WriteLine();
        Console.WriteLine("Company details");
        Console.WriteLine("Name company    {0,-10}", nameCom);
        Console.WriteLine("Address:        {0,-10}", address);
        Console.WriteLine("Phone numer:    {0,-10}", phoneNum);
        Console.WriteLine("Fax number:     {0,-10}", faxNum);
        Console.WriteLine("Web site:       {0,-10}", webSite);
        Console.WriteLine();
        Console.WriteLine("Manager details : ");
        Console.WriteLine("First name:     {0,-10}", webSite);
        Console.WriteLine("Last name:      {0,-10}", webSite);
        Console.WriteLine("Age:            {0,-10}", webSite);
        Console.WriteLine("Phone numer:    {0,-10}", phoneNum);

    }
}

