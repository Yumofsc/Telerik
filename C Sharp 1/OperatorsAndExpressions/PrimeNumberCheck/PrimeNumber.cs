//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer 
//number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;
class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Type number:");
        int n = int.Parse(Console.ReadLine());
        double sqrt = Math.Sqrt(n);
        bool isTrue = true;
        for (int i = 2; i <= sqrt; i++)
        {
            if (n % i == 0)
            {
                isTrue = false;
            }
        }
        if (n == 1 || n <= 0)
        {
            isTrue = false;
        }
        Console.WriteLine("{0} is prime - {1}", n, isTrue);
    }
}
