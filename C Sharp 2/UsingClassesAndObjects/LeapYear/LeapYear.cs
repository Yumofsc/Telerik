using System;

//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter Year you want to check:");
        int checkedYear = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(checkedYear) == true)
        {
            Console.WriteLine("The year {0} is a leap one", checkedYear);
        }
        else
        {
            Console.WriteLine("The year {0} is NOT a leap one", checkedYear);
        }
    }
}

