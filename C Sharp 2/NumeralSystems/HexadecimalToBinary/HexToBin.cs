using System;

//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).
class HexToBin
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(hex2binary(hexNumber));
    }
    static string hex2binary(string hexNumber)
    {
        string binaryNumber = "" ;
        binaryNumber = Convert.ToString(Convert.ToInt32(hexNumber, 16), 2);

        return binaryNumber;
    }

}
