using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input: 	                                | output:
//C# is not C++, not PHP and not Delphi!	| Delphi not and PHP, not C++ not is C#!

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        char[] symbols = new char[] { ',', '!', ' ' };

        string[] words = sentence.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        StringBuilder sb = new StringBuilder();
        int wordsCount = 0;
        bool hasWord = false;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (symbols.Contains(sentence[i]))
            {
                if (hasWord)
                {
                    sb.Append(words[wordsCount]);
                    wordsCount++;
                    hasWord = false;
                }

                sb.Append(sentence[i]);
            }
            else
            {
                hasWord = true;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}