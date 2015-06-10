//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeTheNumbersOneToN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Random rnd = new Random();
        int counter = 0;
        while (counter < n)
        {
            int randomNumber = rnd.Next(0, n);
            int currentNumber = numbers[randomNumber];

            if (currentNumber >= 0)
            {
                Console.Write(currentNumber + " ");
                numbers[randomNumber] = -1;
                counter++;
            }
        }
    }
}

