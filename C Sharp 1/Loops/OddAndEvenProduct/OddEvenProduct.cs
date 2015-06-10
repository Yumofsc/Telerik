//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
class OddEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(' ');
        int odd = 1;
        int even = 1;

        for (int i = 0; i < stringNumbers.Length; i++)
        {
            int number = int.Parse(stringNumbers[i]);
            if ((i + 1) % 2 == 0)
            {
                odd *= number;
            }
            else
            {
                even *= number;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}", odd);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0} \neven_product = {1}", odd, even);
        }
    }
}