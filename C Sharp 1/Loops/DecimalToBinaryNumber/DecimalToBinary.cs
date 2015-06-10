//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionalityusing System;
using System;
class DecimalToBinary
{
    static void Main()
    {
        int decNumber = int.Parse(Console.ReadLine());
        string result = "";

        while (decNumber > 0)
        {
            result = decNumber % 2 + result;
            decNumber = decNumber / 2;
        }
        Console.WriteLine("Result in binary: " + result);  
    }
}
