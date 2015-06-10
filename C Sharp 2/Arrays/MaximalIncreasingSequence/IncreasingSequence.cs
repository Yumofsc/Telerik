//Problem 5. Maximal increasing sequence

//    Write a program that finds the maximal increasing sequence in an array.

//Example:
//input 	             |   result
//3, 2, 3, 4, 2, 2, 4 	 |   2, 3, 4

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter leight of the array:");

        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int currectSeq = 1;
        int bestSeq = 1;
        string currectNum = "";
        string bestNum = "";

        Console.WriteLine("Enter digits in the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currectSeq++;
                currectNum += array[i] + ",";
            }
            else
            {
                if (currectSeq > bestSeq)
                {
                    bestSeq = currectSeq;
                    currectNum += array[i] + ",";
                    bestNum = currectNum;
                }
                currectSeq = 1;
                currectNum = "";
            }
        }
        if (currectSeq > bestSeq)
        {
            currectNum += array[array.Length - 1];
            bestNum = currectNum;
        }
        Console.WriteLine("The maximal increasing sequence in an array: {0}", bestNum);
    }
}
