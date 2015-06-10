//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
class SumFiveNumbers
{
    static void Main()
    {
        Console.Write("Enters a 5 numbers separated by a space: ");
        string[] num = Console.ReadLine().Split(' ');
        double a = double.Parse(num[0]);
        double b = double.Parse(num[1]);
        double c = double.Parse(num[2]);
        double d = double.Parse(num[3]); 
        double e = double.Parse(num[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("{0}+{1}+{2}+{3}+{4} = {5}", a, b, c, d, e, sum);

    }
}
