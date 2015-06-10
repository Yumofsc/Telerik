/* Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	| output
512	    | two
1024	| four
12309	| nine  */


using System;
class DigitToText
{
    static void Main()
    {
        Console.WriteLine("Enter number here");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(NumberToText(n));
       
    }
    static string NumberToText(int number)
    {
        int digit = number % 10;
        string digitToString = String.Empty;
        switch (digit)
        {
            case 1: digitToString = "one"; break;
            case 2: digitToString = "two"; break;
            case 3: digitToString = "three"; break;
            case 4: digitToString = "four"; break;
            case 5: digitToString = "five"; break;
            case 6: digitToString = "six"; break;
            case 7: digitToString = "seven"; break;
            case 8: digitToString = "eight"; break;
            case 9: digitToString = "nine"; break;
            case 0: digitToString = "zero"; break;
        }
        return digitToString;           
    }
}

