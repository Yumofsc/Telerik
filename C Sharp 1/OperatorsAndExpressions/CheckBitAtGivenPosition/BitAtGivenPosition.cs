//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;
class BitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter bit position (n):");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool isTrue = bit == 1;
        Console.WriteLine("Is it byte at position \"n\" = 1? \n{0}", isTrue);
    }
}