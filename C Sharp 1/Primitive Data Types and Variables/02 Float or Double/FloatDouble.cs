//Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatDouble
{
    static void Main()
    {
        float lowNum = 12.345F;
        float highNum = 3456.091F;
        double minNum = 34.567839023;
        double maxNum = 8923.1234857;
        Console.WriteLine("The Data Types and Variables are:");
        Console.WriteLine(" float {0} \n float {1} \n double {2} \n double {3} ", -lowNum, highNum, minNum, maxNum);
    }
}