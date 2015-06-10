//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                  |  result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3   |  4 (5 times)

using System;
class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter array leight:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Now enter elements:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int frequent = array[0];
        int count = 1;
        int maxCount = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = (i + 1); j < n; j++)
            {
                
                if (array[j] == array[i])
                {
                    count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    frequent = array[j];
                }
            }
            count = 1;
        }
        
        Console.WriteLine("The most frequent number in an array is: {0}({1} times)", frequent, maxCount);
    }
}