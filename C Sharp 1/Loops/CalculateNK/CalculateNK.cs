//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Enter value for \"n\":");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for \"k\":");
        int k = int.Parse(Console.ReadLine());
        int facturelN = 1;
        int facturelK = 1;
        int result = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                facturelK *= i;
            }
            facturelN *= i;
        }
        result = facturelN / facturelK;
        Console.WriteLine(result);
    }
}
