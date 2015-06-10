//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
class CountingApperances
{
    static void Main()
    {
        int[] array = { 543, 34, 54, 54, 32, 2345, 2, 54, 32, 87, 125, 5, 432, 23, 45, 54 };
        Console.WriteLine("The array is {0} :", String.Join(", ", array));
        Console.WriteLine("Enter number to check it:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number appears {0} times",NumberOfDigitAppears(array, n));
    }
    static int NumberOfDigitAppears(int[] currectArray, int currectDigit)
    {
        int counter = 0;
        for (int i = 0; i < currectArray.Length; i++)
        {
            if (currectArray[i] == currectDigit)
            {
                counter++;
            }
        }
        return counter;
        
    }
}
