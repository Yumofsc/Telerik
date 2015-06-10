//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.

using System;
class BitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter bit position :");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value:");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        if (v == 0)
        {
            n = n & (~mask);
            Console.WriteLine("The result is:\n{0}\nand new value of: {1}",
                Convert.ToString(n, 2).PadLeft(32, '0'), n);
        }
        else 
        {
            n = n | mask;
            Console.WriteLine("The result is:\n{0}\nand new value of: {1}", 
                Convert.ToString(n, 2).PadLeft(32, '0'), n); 
        } 
    }
}