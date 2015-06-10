using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.
//So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
namespace SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.";
            int counter = 0;
            string subText = "in";
            int index = text.IndexOf(subText);

            while (index != -1 )
            {
                counter++;
                index = text.IndexOf(subText, index + 1);
            }
            Console.WriteLine(counter);
        }
        
    }
}
