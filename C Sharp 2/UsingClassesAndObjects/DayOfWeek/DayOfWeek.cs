using System;

//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.
class DayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("The day of the week for {0:d/M/yyyy} is {1}.", today, today.DayOfWeek);
    }
}

