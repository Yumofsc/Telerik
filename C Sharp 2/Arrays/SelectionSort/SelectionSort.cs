//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;
class SelectionSort
{
    static void Main()
    {
        int[] array = {5, 1, 2, 6, 8, 3, 4};
        int minValue;

        int minIndex = -1;
        

        for (int i = 0; i < array.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (minValue > array[j])
                {
                    minValue = array[j];
                    minIndex = j;
                }
            }
            int temp = array[i];
            array[i] = minValue;
            array[minIndex] = temp;
        }
        Console.WriteLine(string.Join(", ", array));
    }
}
