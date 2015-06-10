//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Type a number:");
        int n = int.Parse(Console.ReadLine());
       
        if (n % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}