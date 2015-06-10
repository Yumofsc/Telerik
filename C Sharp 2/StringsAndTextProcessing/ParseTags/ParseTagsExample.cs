using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions
surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. */

class ParseTagsExample
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("The given text is: \n{0}", text);
        string openSeparator = "<upcase>";
        string closeSeparator = "</upcase>";
        int openIndex = text.IndexOf(openSeparator);
        int closeIndex = text.IndexOf(closeSeparator);

        do
        {
            int startIndex = openIndex + openSeparator.Length;
            int subTextLenght = closeIndex - (openIndex + openSeparator.Length);
            string formatText = text.Substring(startIndex, subTextLenght);
            text = text.Replace(formatText, formatText.ToUpper());
            openIndex = text.IndexOf(openSeparator, openIndex + 1);
            closeIndex = text.IndexOf(closeSeparator, closeIndex + 1);

        }
        while (openIndex != -1);
        {
            text = text.Replace(openSeparator,"");
            text = text.Replace(closeSeparator,"");
            Console.WriteLine("The Expectet result is: \n{0}",text);
        }
    }
}
