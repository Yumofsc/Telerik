//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        int digit = 0;
        int power = 0;
        int sum = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            char hexDigit = hexNumber[i];

            if (hexDigit >= 'A')
            {
                digit = 10 + hexDigit - 'A';
            }
            else
            {
                digit = (int)(hexDigit - '0');
            }
            power = (hexNumber.Length - 1 - i);
            sum += digit * (int)Math.Pow(16, power);

        } 
        Console.WriteLine(sum);
    }
}


