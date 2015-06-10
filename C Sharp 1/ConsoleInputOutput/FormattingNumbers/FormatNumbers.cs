//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
class FormatNumbers
{
    static void Main()
    {
        Console.WriteLine("Pleace enter value for \"a\":");
        int a = int.Parse(Console.ReadLine());

        bool exeption = 0 <= a && a <= 500;
        if (exeption == true)
        {
            Console.WriteLine("\"a\" is in (0 <= a <= 500)");

            Console.WriteLine("Pleace enter value for \"b\":");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Pleace enter value for \"c\":");
            double c = double.Parse(Console.ReadLine());
            string bit = Convert.ToString(a, 2).PadLeft(10, '0');


            Console.WriteLine();
            Console.WriteLine("|{0,-10:X}|{3}|{1,10:F2}|{2,-10:F3}|", a, b, c, bit);
        }
        else
        {
            Console.WriteLine("\"a\" is not between 0 and 500. Pleace enter a valid number");
        }
    }
}

