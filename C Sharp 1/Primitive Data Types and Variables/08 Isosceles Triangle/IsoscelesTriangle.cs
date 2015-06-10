//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char c = '©';
       
        Console.WriteLine("   {0}   \n\n  {0} {0}  \n\n {0}   {0} \n\n{0} {0} {0} {0}", c);

    }
}

