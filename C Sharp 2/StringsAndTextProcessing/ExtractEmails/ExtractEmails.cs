using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
class ExtractEmails
{
    static void Main()
    {
        //string text = "My E-mail is /MichaelBay@gmail.com/, and my company e-mail is /LegendaryPictures@gmail.com/";
        //Console.WriteLine(text);
        //Console.WriteLine("The emails are:");
        //Console.WriteLine(String.Join("\n", ExtractEmail(text)));

        string email = "My E-mail is /MichaelBay@gmail.com/, and my company e-mail is /LegendaryPictures@gmail.com/";
        string regex = @"\w+@\w+\.\w+";

        MatchCollection matches = Regex.Matches(email, regex, RegexOptions.IgnorePatternWhitespace);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
   
}
