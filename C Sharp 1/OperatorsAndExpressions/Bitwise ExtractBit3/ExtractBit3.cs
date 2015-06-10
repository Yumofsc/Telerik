//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;
class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int p = 3;
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("The #3 bit is:");
        Console.WriteLine(bit);
    }
}