using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.




/* 
 * A string is an object of type String whose value is text. 
 * Internally, the text is stored as a sequential read-only collection of Char objects. 
 * There is no null-terminating character at the end of a C# string; 
 * therefore a C# string can contain any number of embedded null characters ('\0'). 
 * The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. 
 * To access the individual Unicode code points in a string, use the StringInfo object.
 * * Equals(string text)
 * Equals(string text, StringComparison.CurrentCultureIgnoreCase)
 * CompareTo(string text)
 * Compare(string text1, string text2, bool isIgnoredCase)
 * ToUpper()/ToLower()
 * IndexOf(string text)
 * LastIndexOf(string text)
 * Substring(int index, int length)
 * Split(char[] separators, StringSplitoptions.RemoveEmptyEntries)
 * Replace(string text1, string text2)
 * Regex.Replace(string text, "(string const)[sequence from char to char]{number of elements}", "$1****");
 * Trim()
 * Trim(char[] symbols)
 * TrimEnd()/TrimStart()
 * Format("{0}",var)
 * type.Parse
 *    StringBuilder Methods:
 * Append(string text)
 * ToString()
 * Clear()
 * Remove(int startIndex, int length)
 * Insert(int startIndex, string text)
 */
class StringsInCSharp
{
    static void Main()
    {

    }
}

