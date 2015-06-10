//Problem 8. Maximal sum

//    Write a program that finds the sequence of maximal sum in given array.

//Example:
//input 	                        | result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8  | 2, -1, 6, 4

//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Find maximal sum in given array: \n2, 3, -6, -1, 2, -1, 6, 4, -8, 8");
        int[] array = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        

        int start, end, temp;
        start = end = temp = 0;
        int maxSum = int.MinValue;
        int sum = 0;
        

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
           
            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
                start = temp;
            }
            if (sum <= 0)
            {
                sum = 0;
                temp = i + 1;
            }
        }
        for (int i = start; i <= end; i++)
        {
            
            Console.Write(array[i] + (i != end ? ", " : ""));
        }
        Console.WriteLine();
    }
}
