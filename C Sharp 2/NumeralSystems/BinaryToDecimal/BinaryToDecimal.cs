//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;
class BinaryToDecimal
{
    static void Main()
    {
       string binNumber = Console.ReadLine();
        Console.WriteLine(ConvertBinToDec(binNumber));
    }
    static long ConvertBinToDec(string binNumber)
    {
        long decNumber = 0;
        for (int i = 0; i < binNumber.Length; i++)
        {
            int digit = binNumber[i] - '0';
            int position = binNumber.Length - i - 1;
            decNumber += digit * (long)Math.Pow(2, position);
        }
        return decNumber;
    }
}
