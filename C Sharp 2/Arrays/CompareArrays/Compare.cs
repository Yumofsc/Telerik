//Problem 2. Compare arrays

//    Write a program that reads two integer arrays from the console and compares them element by element.


using System;
class Compare
{
    static void Main()
    {
        Console.WriteLine("Enter First Arrays leight");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
       
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter Secound Arrays leight");
        int m = int.Parse(Console.ReadLine());
        int[] secoundArray = new int[m];
       
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < m; i++)
        {
            secoundArray[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < n; i++)
        {
            if (n != m)
            {
                Console.WriteLine("The arrays dont have equal elements");
                break;
            }
            if (firstArray[i] > secoundArray[i])
            {
                Console.WriteLine(" {0} > {1}", firstArray[i], secoundArray[i]);
            }
            else if (firstArray[i] < secoundArray[i])
            {
                Console.WriteLine(" {0} > {1}", secoundArray[i], firstArray[i]);
            }
            else if (firstArray[i] == secoundArray[i])
            {
                Console.WriteLine(" {0} = {1}", secoundArray[i], firstArray[i]);
            }
        }
    }
}
