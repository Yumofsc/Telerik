//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Type the numbers to make check:");
        int number = int.Parse(Console.ReadLine());
        bool digit = (number / 100) % 10 == 7;
        Console.WriteLine(digit);
    }
}

