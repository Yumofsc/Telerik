using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	      | output
//.NET	      | platform for applications from Microsoft
//CLR	      | managed execution environment for .NET
//namespace	  | hierarchical organization of classes

class WordDictionary
{
    static void Main()
    {
        string text = @".NET-platform for applications from Microsoft
CLR-managed execution environment for .NET
namespace-hierarchical organization of classes";

        char[] separators = { '\n', '-' };
        string[] textAray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        var dictionary = new Dictionary<string, string>();

        for (int i = 0; i < textAray.Length; i+=2)
        {
            dictionary.Add(textAray[i], textAray[i + 1]);
        }

        Console.WriteLine("Enter word:");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine(dictionary[word]);
        }
        else
        {
            Console.WriteLine("there is no such word!");
        }


    }
}

