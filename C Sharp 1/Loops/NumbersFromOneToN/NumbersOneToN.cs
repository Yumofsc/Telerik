/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints
all the numbers from 1 to n, on a single line, separated by a space.*/

using System;
class NumbersOneToN
{
    static void Main()
    {
        Console.WriteLine("Please Enter number:");
        int n = int.Parse(Console.ReadLine());
        int i = 0;
        while (i < n)
        {
            Console.Write("{0} ", i);
            i++;
        }
    }
}
