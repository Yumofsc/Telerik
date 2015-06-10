/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by formula. For example, 
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
Try to use only two loops. */

using System;
using System.Numerics;
class DoAdvanceNK
{                               // 5! = 120 ;; 3! = 6
    static void Main()
    {
        Console.WriteLine("Enter value for \"n\":");
        int n = int.Parse(Console.ReadLine());     
       
        Console.WriteLine("Enter value for \"k\":");
        int k = int.Parse(Console.ReadLine());

        BigInteger facturelN = 1;
        BigInteger facturelK = 1;
        int sum = n - k;
        BigInteger facturelSum = 1;
        BigInteger answer = 1;

        
            for (int i = 1; i <= n ; i++)
            {
                if (i <= k)
                {
                    facturelK *= i;
                }
                facturelN *= i;
            }
            
            for (int i =1; i <= sum; i++)
            {
                facturelSum *= i;
            }
            answer = facturelN / (facturelK * facturelSum);                          //  n! / (k! * (n-k)!)
            Console.WriteLine("The answer is {0}:", answer);
    }
}