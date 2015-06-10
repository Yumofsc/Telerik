//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
class Binary                 // NOT COMPLETE!
{
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number which index we are going to looking for:");
        int s = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter {0} number(s) to array:", n);
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);
        Console.WriteLine("Array after sorting: {0}", string.Join(", ", nums));

        int index = BinarySearch(nums, s, 0, nums.Length);

        if (index != -1) Console.WriteLine("Number {0} found at index: {1}", s, index);
        else Console.WriteLine("Number {0} not found!", s);
    }

    private static int BinarySearch(int[] array, int number, int start, int end)
    {
        if (end < start)
        {
            return -1;
        }
        else
        {
            int middlePoint = (start + end) / 2;
            if (array[middlePoint] > number)
            {
                return BinarySearch(array, number, start, middlePoint - 1);
            }
            else if (array[middlePoint] < number)
            {
                return BinarySearch(array, number, middlePoint + 1, end);
            }
            else
            {
                return middlePoint;
            }
        }
    }
}
