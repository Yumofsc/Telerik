//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours
//(when such exist).

using System;
class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] curectArray = { 1, 3, 3, 9, 5, 4, 5, 3, 2, 2, 9, 6, 8 };

        Console.WriteLine("the array is: {0}", String.Join(", ", curectArray));
        Console.WriteLine("Enter a position of element to be checked in the array:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(LargeThanNeighbours(curectArray, position) ?
            "This element is larger than it's neighbours" : "This element is not larger than it's neighbours");
    }
    static bool LargeThanNeighbours(int[] array, int index)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (index > 0 && index < array.Length - 1 && array[index] > array[index - 1] && array[index] > array[index + 1])
             {
                 return true;
             }
        }
        return false;
    }
}
