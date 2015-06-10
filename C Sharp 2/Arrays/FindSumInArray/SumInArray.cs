//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                |  S	|  result
//4, 3, 1, 4, 2, 5, 8	|  11	|  4, 2, 5
                                    
using System;
class SumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter the sum that you want to check for:");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Now enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isTrue = false;
        int sum = 0;
        
        for (int i = 0; i < array.Length && !isTrue; i++)
        {
            sum = array[i];
            string printSum = array[i] + ",";

            for (int j = i + 1; j < array.Length && !isTrue; j++)
            {
                sum += array[j];
                printSum += array[j] + ",";

                if (sum == s)
                {
                    Console.WriteLine("The sequence of this array is: {0}",printSum);
                    isTrue = true;
                }
            }
        }
        if (!isTrue)
        {
            Console.WriteLine("There is no Sequence in this array");
        }
    }
}