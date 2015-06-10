//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
class QuickSort
{
    public static void quicksort(int[] input, int low, int high)
    {
        int pivot_loc = 0;

        if (low < high)
        {
            pivot_loc = partition(input, low, high);
            quicksort(input, low, pivot_loc - 1);
            quicksort(input, pivot_loc + 1, high);
        }

    }

    private static int partition(int[] input, int low, int high)
    {
        int pivot = input[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (input[j] <= pivot)
            {
                i++;
                swap(input, i, j);
            }
        }
        swap(input, i + 1, high);
        return i + 1;
    }



    private static void swap(int[] array, int a, int b)
    {
        int temp;
        temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }


    static void Main()
    {
        // demo array
        //int[] demoArr = Enumerable.Range(-10, 20).ToArray();
        int[] demoArray = new int[15];

        // initialize 
        for (int i = 0; i < 15; i++)
        {
            if ((i & 1) == 0)
            {
                demoArray[i] = i;
            }
            else
            {
                demoArray[i] = -i;
            }
        }

        foreach (int number in demoArray)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine(" - Unsorted array\nSorted: ");

        quicksort(demoArray, 0, 14);

        foreach (int number in demoArray)
        {
            Console.Write(number + " ");
        }

    }    
   
}
