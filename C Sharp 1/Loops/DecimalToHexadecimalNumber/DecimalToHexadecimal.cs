//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class DecimalToHexadecimal
{
    static void Main()
    {
        int DecNumber = int.Parse(Console.ReadLine());
        string result = "";

        while (DecNumber > 0)
        {
            int CurectDigit = DecNumber % 16;
            char simbol;
            DecNumber = DecNumber / 16;

            if (CurectDigit > 9)
            {
                simbol = (char)(CurectDigit - 10 + 'A');
            }
            else
                simbol = (char)(CurectDigit + '0');
            result = simbol + result;
        }
        Console.WriteLine(result);
    }
}
