//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter 
//and area formatted with 2 digits after the decimal point.

using System;
class CirclePAndS                       // P = 2πr  ;  S = πr2
{
    static void Main()
    {
        Console.WriteLine("Pleace enter radius \"r\":");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double p = 2 * pi * r;
        double rPow = Math.Pow(r, 2);
        double s = pi * rPow;
        Console.WriteLine("The circle perimeter is: {0:F2}", p);
        Console.WriteLine("The circle area is: {0:F2}", s);
    }
}
