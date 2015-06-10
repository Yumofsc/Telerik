//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
class Multiplication
{
    static void Main()
    {
        Console.WriteLine("Please type first number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please type secound number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please type third number:");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("{0} | {1} | {2} | 0 ", a, b, c);
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("{0} | {1} | {2} | + ", a, b, c);
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("{0} | {1} | {2} | - ", a, b, c);
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("{0} | {1} | {2} | - ", a, b, c);
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("{0} | {1} | {2} | - ", a, b, c);
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("{0} | {1} | {2} | - ", a, b, c);
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("{0} | {1} | {2} | + ", a, b, c);
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("{0} | {1} | {2} | + ", a, b, c);
        }
    }
}
