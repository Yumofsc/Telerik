using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
Consider that the sentences are separated by . and the words – by non-letter symbols. */

class ExtractSentences
{
    static void Main()
    {
        {
            Console.Write("Enter text: ");
            //Get an array of sentences
            string[] input = Console.ReadLine().Trim().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Enter a word to look for: ");
            string word = Console.ReadLine();
            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] words = input[i].Trim().Split(new[] { ' ', ',', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Contains(word))
                {
                    result.Add(input[i]);
                    result.Add(".");
                }
            }

            Console.WriteLine(string.Join("", result));
        }

    }
}

