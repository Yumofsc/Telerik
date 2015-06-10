using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on
 * .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. 
It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***. */

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on.NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("The text is: \n{0}", text);
        Console.WriteLine();
        string forbidWords = "PHP, CLR, Microsoft";
        Console.WriteLine("The forbidden words are: \n{0}", forbidWords);
        Console.WriteLine();
        string[] forbidWordsArr = forbidWords.Split(new string[] { ",", ".", " " },StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbidWordsArr.Length; i++)
        {
            StringBuilder build = new StringBuilder();
            build.Append('*', forbidWordsArr[i].Length);
            text = text.Replace(forbidWordsArr[i], build.ToString());
        }
        Console.WriteLine("The text afrer replacement: \n{0}", text);
    }
}

