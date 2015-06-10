﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class StrangeLand
{
    static void Main()
    {
        string text = Console.ReadLine()
        .Replace("f", "0")
        .Replace("bIN", "1")
        .Replace("oBJEC", "2")
        .Replace("mNTRAVL", "3")
        .Replace("lPVKNQ", "4")
        .Replace("pNWE", "5") 
        .Replace("hT", "6");

        int power = 0;
        BigInteger result = 0;

        for (int i = text.Length - 1; i >= 0; i--)
        {
            int currentNumber = text[i] - '0';

            result += currentNumber * Power(7, power);
            power++;
        }
        Console.WriteLine(result);

    }
    static BigInteger Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }

}
