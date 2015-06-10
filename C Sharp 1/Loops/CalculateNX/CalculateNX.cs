//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

// 1 + 1!/x^1 + 2!/x^2 + 3!/x^3 + 4!/x^4

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;
class CalculateNX
{                           
    static void Main()
    {
        Console.WriteLine("Type value for \"n\"");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Type value for \"x\"");
        double x = double.Parse(Console.ReadLine());

        double f = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            f *= i;
            result += f / (Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}",result);
    }
}