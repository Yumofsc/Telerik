//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstN = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondN = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdN = double.Parse(Console.ReadLine());

        if (firstN <= secondN && firstN <= thirdN)
        {
            Console.WriteLine("The biggest one is {0}", firstN);
        }
        else if (secondN <= firstN && secondN <= thirdN)
        {
            Console.WriteLine("The biggest one is {0}", secondN);
        }
        else if (thirdN <= firstN && thirdN <= secondN)
        {
            Console.WriteLine("The biggest one is {0}", thirdN);
        }
    }
}
