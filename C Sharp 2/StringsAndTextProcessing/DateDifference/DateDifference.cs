using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

class DateDifference
{
    static void Main(string[] args)
    {
        string begin = "27.06.2006";
        string ends = "3.09.2006";

        DateTime startDate = DateTime.ParseExact(begin, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(ends, "d.MM.yyyy", CultureInfo.InvariantCulture);
        var summerDays = (endDate - startDate).TotalDays;
        Console.WriteLine("Distance: {0}", summerDays);
    }
}
