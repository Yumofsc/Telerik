/* Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K,
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

using System;
class BinarySearch
{
    static void Main()
    {       
        //input
        Console.WriteLine("Please enter K number: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Arrays leight: ");
        int n = int.Parse(Console.ReadLine());

        // creating and filling array
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //Printing sorted array
        Array.Sort(array);
        
        Console.WriteLine("The sorted aray is : ");
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();

        // Check if all numbers are > K
        if (array[0] > k)
        {
            Console.WriteLine("There is no number in the array which is equal or less than {0}.", k);
        }

        //Printing the result
        for (int i = k; i >= 0; i--)
        {
            if (Array.BinarySearch(array, i) >= 0)
            {
                Console.WriteLine("The largest number equal or less than {0} is {1}.", k, i);
                return;
            }
        }
    }
}
