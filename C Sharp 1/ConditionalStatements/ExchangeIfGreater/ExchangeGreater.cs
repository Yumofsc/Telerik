//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges
//their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

using System;
class ExchangeGreater
{
    static void Main()
    {
        Console.WriteLine("Please type first variable:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please type secound variable:");
        double b = double.Parse(Console.ReadLine());
        double c = a;
        if (a > b)
        {

            Console.WriteLine("{0} {1}", a, b);
        }
        else 
        {
            Console.WriteLine("{0} {1}",b, a);


        }
    }
}