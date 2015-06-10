//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input 	| output
//256	    | 652
//123.45	| 54.321

using System;
using System.Linq;
class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the number that you want to reverse:");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number is: {0} ", ReverseDigit(number));
     
    }
    static decimal ReverseDigit(decimal number)
    {
        string text = Convert.ToString(number);
        char[] toCharArray = text.ToCharArray();
        Array.Reverse(toCharArray);
        string convert = new string(toCharArray);
        decimal result = decimal.Parse(convert);
        return result;
    }
}
