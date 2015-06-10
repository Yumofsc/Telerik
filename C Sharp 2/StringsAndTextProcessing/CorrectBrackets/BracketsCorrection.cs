using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))
namespace CorrectBrackets
{
    class BracketsCorrection
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int leftBrackets = 0;
            int rightBrackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBrackets++;
                }
                if (expression[i] == ')')
                {
                    rightBrackets++;
                }
            }
            Console.WriteLine("Are brackets in the expression put currectly?");
            Console.WriteLine(leftBrackets != rightBrackets ? false : true);
        }
    }
}
