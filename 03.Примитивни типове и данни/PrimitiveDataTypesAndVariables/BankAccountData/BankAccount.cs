
//Problem 11.	Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstname = "Dilyana";
        string middleName = "Petrova";
        string lastName = "Urumova";
        object fullName = firstname + " "+ middleName + " " + lastName;
        decimal balance = 78478.98m;
        string bankName = "Unibank";
        string iban = "BG80BNBG96611020345678";
        string bic = "STSABGSF";
        ulong creditCardNumber1 = 123656780001134u;
        ulong creditCardNumber2 = 173456780023112u;
        ulong creditCardNumber3 = 183456780001513u;
        Console.WriteLine("Account holder: " + fullName
        + "\nBalance: " + balance
        + " BGN\nBank: " + bankName
        + "\nIBAN: " + iban
        + "\nBIC: " + bic
        + "\nCredit Card 1: BG" + creditCardNumber1
        + "\nCredit Card 2: BG" + creditCardNumber2
        + "\nCredit Card 3: BG" + creditCardNumber3);
    }
}

