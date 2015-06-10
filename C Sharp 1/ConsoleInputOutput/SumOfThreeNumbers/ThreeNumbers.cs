//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
class ThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter secound number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;

        Console.WriteLine("The summary of these numbers is :\n{0}", sum);
    }
}
