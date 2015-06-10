using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
class DateBulgarian
{
    static void Main()
    {
        DateTime date = new DateTime(2015, 08, 21, 3,30, 15);
        date = date.AddHours(6);
        date = date.AddMinutes(30);
        Console.WriteLine("New date is: {0:dd.MM.yyyy dddd}", date);
    }
}

