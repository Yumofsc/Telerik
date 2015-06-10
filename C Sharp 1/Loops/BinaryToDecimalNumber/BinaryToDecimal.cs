//Problem 13. Binary to Decimal Number 

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long sum = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
           int binaryDigit = binaryNumber[i];
           int number = binaryDigit - '0';
           int power = (binaryNumber.Length - 1) - i;
           long result = number * (long)Math.Pow(2, power);
           sum += result;
        }
        Console.WriteLine(sum);
    }
}
