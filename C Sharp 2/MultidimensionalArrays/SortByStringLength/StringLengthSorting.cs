/* Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by
the length of its elements (the number of characters composing them). */

using System;
using System.Linq;
class StringLengthSorting
{
    static void Main()
    {
        Console.WriteLine("Please enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please, enter element[{0}]: ", i);
            array[i] = Console.ReadLine();
        }

        // compare strings
        Array.Sort(array, (x1, x2) => x1.Length.CompareTo(x2.Length));
        
        //printing matrix
        Console.WriteLine("Sorted array is: ");
        foreach (var item in array)
        {
            Console.Write("{0}, ",item);
        }
        Console.WriteLine();
    }
}
