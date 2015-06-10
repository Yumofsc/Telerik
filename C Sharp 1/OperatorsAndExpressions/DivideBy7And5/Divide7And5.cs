//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
class Divide7And5
{
    static void Main()
    {
        Console.WriteLine("Type a number:");
        int n = int.Parse(Console.ReadLine());
        bool isTrue = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(isTrue);

    }
}


