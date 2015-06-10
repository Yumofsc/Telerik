using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	| output
//Hi!	| \u0048\u0069\u0021

class UnicodeChars
{
    static void Main()
    {
        Console.WriteLine("Enter input:");
        string input = Console.ReadLine();
        foreach (char symbol in input)
        {
            Console.Write("\\n{0:x4}", (int)symbol);
        }
        Console.WriteLine();
    }
}

