//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary is: \n{0}",ConvertDecToBin(number));
    }
    static string ConvertDecToBin(int decNumber)
    {
        string binNumber = "";
        while (decNumber > 0)
        {
            var digit = decNumber % 2;
            binNumber = digit + binNumber;
            decNumber /= 2;
        }
        return binNumber;
    }
}

