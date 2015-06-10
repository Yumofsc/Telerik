using System;
using System.Numerics;
class p369
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        BigInteger R = 0;
        BigInteger divR = 0;

        if (B == 3)
        {
            R = A + C;
        }
        else if (B == 6)
        {
            R = A * C;
        }
        else if (B == 9)
        {
            R = A % C;
        }

        if (R % 3 == 0)
        {
            divR = R / 3;
        }
        else
        {
            divR = R % 3;
        }

        Console.WriteLine(divR);
        Console.WriteLine(R);
    }   
}
