using System;
using System.Text;

/* Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	| output
sample  | elpmas             */
class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter text here:");
        string text = Console.ReadLine();
        Console.WriteLine("The reverse text is: {0}", ReversText(text));
    }
    static string ReversText(string text)
    {
        StringBuilder result = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            result.Append(text[i]);
        }
        return result.ToString();
    }
}

