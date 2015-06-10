using System;

//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.
class DecToHex
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHexadecimal(decNumber));
    }
    static string DecimalToHexadecimal(long decNumber)
    {
        string hexNumber = "";
        while (decNumber > 0)
        {
            long digit = decNumber % 16;
            if (digit >= 0 && digit <= 9)
            {
                hexNumber = (char)(digit + '0') + hexNumber;
            }
            else if (digit >= 10 && digit <= 15)
            {
                hexNumber = (char)(digit - 10 + 'A') + hexNumber;
            }
            decNumber /= 16;
        }

        return hexNumber;
    }
    
}
