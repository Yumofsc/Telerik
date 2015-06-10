//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: (2N)! / (N+1)! * N!
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//answer = (factSum) / ((factSum2) * (factN));
using System;
using System.Numerics;
class CatalanNum
{
    static void Main()
    {
        Console.WriteLine("Enter value for \"n\":");
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger sum = 2 * n;
        BigInteger factN = 1;
        BigInteger factSum = 1;
        BigInteger answer = 1;


        for (int i = 1; i <= sum; i++)
        {
            factSum *= i;       //(2N)!
            if (i <= n)
            {
                factN *= i;     //N!                     
            }

            answer = (factSum) / ((factN * (n + 1)) * (factN));
        }
        Console.WriteLine("The answer is : {0}", answer);
    }
}

