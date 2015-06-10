//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Type a value for side \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Type a value for side \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Type a value for height \"h\": ");
        double h = double.Parse(Console.ReadLine());
        double s = ((a + b) / 2) * h;
        Console.WriteLine("The Aria of the Trapezoid is: \n{0}", s);  
    }
}
