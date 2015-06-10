using System;
class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double arithmetic = 0;

        //if (a >= b)
        //{
        //   if (a > c)
        //   {
        //       Console.WriteLine(a);
        //   }
        //   else
        //   {
        //       Console.WriteLine(c);
        //   }
        //}
        //else
        //{
        //    if (b >= c)
        //    {
        //        Console.WriteLine(b);
        //    }
        //    else 
        //    {
        //        Console.WriteLine(c);
        //    }
        //}
       





        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine(c);
        }
        if (a <= b && a <= c)
        {
            Console.WriteLine(a);
        }
        else if (b <= a && b <= c)
        {
            Console.WriteLine(b);
        }
        else if (c <= a && c <= b)
        {
            Console.WriteLine(c);
        }
        arithmetic = (a + b + c) / 3.0;
        Console.WriteLine("{0:F2}", arithmetic);
    }
}
