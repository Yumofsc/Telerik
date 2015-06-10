/* Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */

using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(FacturielN(number));
    }
    static BigInteger FacturielN(int number)
    {
        BigInteger facturiel = 1;
        for (int i = 1; i <= number; i++)
        {
            facturiel *= i;
            
        }
        return facturiel;
    }
}