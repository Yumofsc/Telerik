using System;

//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.
class HexToDec
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(HexadecimalToDecimal(hexNumber));
    }
    static long HexadecimalToDecimal(string hexNumber)
    {
        long decNumber = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            int digit = 0;
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                digit = hexNumber[i] + '0';
             
            }
            else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
            {
                digit = hexNumber[i] - 'A' + 10;
                
            }
            var position = hexNumber.Length - 1 - i;
            decNumber += digit * (long)Math.Pow(16, position);
        }   
        return decNumber;
    }
}
