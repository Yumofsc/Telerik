//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("print a number:");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c = a + b;
        int sum = 1;
        if (n >= 1)
        {
            Console.Write(a+",");
        }
        for (int i = 1; i < n; i++)
        {
            Console.Write(sum + ",");
            sum = a + b + c;
            a = b;
            c = a + b;
           c = sum;
            
        }





        //    do
        //    {
        //        sum = a + b;
        //        a = b;
        //        b = sum;

        //        Console.Write(sum +",");
        //    }     while (sum <= n);
    }
}
