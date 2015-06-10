/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.*/

using System;
class MinMaxSumAndAverageOfN
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you want:");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0;
        double avarage = 1;
        for (int i = 1; i <= n; i++)
        {
            int variable = int.Parse(Console.ReadLine());
            if (variable > max)
            {
                max = variable;
            }
            if (variable < min)
            {
                min = variable;
            }

            sum += variable;
        }
        avarage = sum / n;
        
        Console.WriteLine("{0:0.00} ,{1:0.00}", sum, avarage);
        Console.WriteLine("The min value is: {0:0.00},", min);
        Console.WriteLine("The max value is: {0:0.00},", max);
    }
}
