//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.
using System;
class FourDigit
{
    static void Main()
    {
        Console.WriteLine("Pleace type four digits:");
        int n = int.Parse(Console.ReadLine());
        int a = (n / 1000) % 10;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d= n % 10;
        int sum = a + b + c + d;

        Console.WriteLine("The digits are: {0}{1}{2}{3}", a,b,c,d);
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The digits in reversed order: {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last digit in the first position: {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Exchanging the second and the third digits: {0}{2}{1}{3}", a, b, c, d);
        

    }
}
