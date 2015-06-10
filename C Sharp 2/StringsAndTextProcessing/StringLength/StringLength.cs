using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console. */
class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter some text here:");
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            Console.WriteLine("The text is too long");
        }
        else
        {
            StringBuilder editText = new StringBuilder();
            editText.Append(text);
            editText.Append('*', 20 - text.Length);
            Console.WriteLine(editText.ToString());
        }
       
    }
}

