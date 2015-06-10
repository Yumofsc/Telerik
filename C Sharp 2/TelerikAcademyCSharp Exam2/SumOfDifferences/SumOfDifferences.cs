using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class SumOfDifferences
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] catNumbers = numbers.Split(' ');
        BigInteger[] realNumbers = catNumbers.Select(BigInteger.Parse).ToArray();

        BigInteger sum = 0;
        BigInteger difference = 0;
        
        for (int i = 1; i < realNumbers.Length; i++)
        {
            difference = realNumbers[i] - realNumbers[i - 1];
            if (difference % 2 == 0)
            {
                i = i + 1;
            }
            else
            {
                if (difference < 0)
                {
                    difference *= -1;
                }
                sum += difference;
            }
            
        }
        Console.WriteLine(sum);

    }
}


