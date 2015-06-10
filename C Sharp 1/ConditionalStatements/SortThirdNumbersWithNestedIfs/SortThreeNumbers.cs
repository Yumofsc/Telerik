//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a,b,c);
                }
                else // (b < c)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else // (a < c)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else //(a < b)
        {
            if (b < c)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else //(b > c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
    }
}
