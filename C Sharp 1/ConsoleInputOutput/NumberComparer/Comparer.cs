//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
class Comparer
{
    static void Main()
    {
        Console.WriteLine("Pleace enter first number:");
        double numA = double.Parse(Console.ReadLine());
        Console.WriteLine("Pleace enter secound number:");
        double numB = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater one is:\n" + Math.Max(numA, numB));


    }
}