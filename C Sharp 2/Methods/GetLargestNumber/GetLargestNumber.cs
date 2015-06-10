﻿//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter tree int numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (GetMax(a, b) > c )
        {
            Console.WriteLine("The largest number is: {0}", GetMax(a, b));
        }
        else
        {
            Console.WriteLine("The largest number is: {0}", c);
        }
    }
    static int GetMax(int a, int b)
    {
        if (a > b || a == b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
