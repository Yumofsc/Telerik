using System;

//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].
class RandomNumbers
{
    static void Main()
    {
      Random generator = new Random();
      int newGenerator = generator.Next(100, 201);
      Console.WriteLine("Random number: {0}", newGenerator);
    }
}
