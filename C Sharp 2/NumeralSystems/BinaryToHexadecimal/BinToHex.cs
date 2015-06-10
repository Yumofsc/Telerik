//Problem 6. Binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
class BinToHex
{
    static void Main()
    {
        Console.Write("Please, enter binary number: ");
        string binary = Console.ReadLine();
        Console.WriteLine("Hexademical represantation: {0}", Convert.ToInt64(binary, 2).ToString("X"));
    }
}
