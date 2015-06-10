//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
//IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using 
//the appropriate data types and descriptive names.

using System;
class BankAccount
{
    static void Main()
    {
        string fullName = "Konstantin Mitkov Popov";
        decimal balance = 690000000000.00M;
        string bank = "UniCredit Bulbank";
        string iban = "BG40RBOS07213513040915";
        ulong fcard = 5500005555555559;
        ulong scard = 5115915115915118;
        ulong tcard = 4061724061724061;
        Console.WriteLine("World Wide Account Data Base");
        Console.WriteLine("\nAccount holder: {0}", fullName);
        Console.WriteLine("Money Balance: {0}", balance);
        Console.WriteLine("Bank name: {0}", bank);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Master Card:" + fcard);
        Console.WriteLine("Visa:" + scard);
        Console.WriteLine("Maestro:" + tcard);

    }
}