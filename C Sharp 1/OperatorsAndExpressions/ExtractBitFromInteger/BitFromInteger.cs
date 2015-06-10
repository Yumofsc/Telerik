//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter extracted bit number :");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("The extracted bit is:");
        Console.WriteLine(bit);

    }
}
