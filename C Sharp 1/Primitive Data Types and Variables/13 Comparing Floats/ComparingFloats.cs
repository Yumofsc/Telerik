//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter numbers here:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        bool compare = Math.Abs(firstNum - secondNum) < eps;
        Console.WriteLine("Comparing: {0} ", compare);
    }
}
