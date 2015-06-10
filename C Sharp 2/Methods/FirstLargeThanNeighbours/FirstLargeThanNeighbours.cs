/* Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours,
or -1, if there’s no such element.
Use the method from the previous exercise. */

using System;
class FirstLargeThanNeighbours
{
    static void Main()
    {
        int[] givenArray = { 1, 3, 4, 6, 3, 9, 1, 2, 5, 9, 8, 6, 3, 6, 3, };
        //int[] givenArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12 };
        Console.WriteLine("The array is: {0}", String.Join(", ", givenArray));
        Console.WriteLine(TheLargestFirst(givenArray) != -1 ?
            "The first element is larger than it's neighbours is : {0}" : "{0}", TheLargestFirst(givenArray));
    }
    static int TheLargestFirst(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i ;
            }
        }
        return -1;
       
	}
    
}
