//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter bit position (n):");
        int b3 = 3;
        int b24 = 24;
       
          
        int mask1 = 1 << b3;
        int mask2 = 1 << b24;
       
        
        //  UNCOMPLETE !!! \\
    }
}
