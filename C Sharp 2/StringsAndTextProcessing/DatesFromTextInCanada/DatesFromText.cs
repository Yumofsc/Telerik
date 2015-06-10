using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

class DatesFromText
{
    static void Main()
    {
        string text = "I was graduate at 17.12.2015";
        Console.WriteLine("The text is:\n{0}", text);
        Console.WriteLine("In canadian format the date looks like:");
        foreach (Match date in Regex.Matches(text, @"[0-9]{2}.[0-9]{2}.[0-9]{4}"))
        {
            string[] newDate = date.Value.Split('.');
            var dateTwo = new DateTime(Convert.ToInt32(newDate[2]), Convert.ToInt32(newDate[1]), Convert.ToInt32(newDate[0]));

            Console.WriteLine(dateTwo.ToString("yyyy-MM-dd"));
        }
    }
}

