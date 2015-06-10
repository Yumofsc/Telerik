//Problem 4. Maximal sequence

//    Write a program that finds the maximal sequence of equal elements in an array.

//Example:
//input 	                     |   result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1   |	2, 2, 2

using System;
class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter leight of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int currectSeq = 1;
        int bestSeq = 1;
        int number = 0;

        Console.Write("enter elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            
            if (array[i] == array[i + 1])
            {
                currectSeq++;
            }
            else
            {
                currectSeq = 1;
            }
            if (currectSeq >= bestSeq)
            {
                bestSeq = currectSeq;
                number = array[i];
            }
            
        }
        for (int i = 0; i < bestSeq; i++)
        {
            Console.Write("{0}, ", number);
        }
        Console.WriteLine();
    }
}
