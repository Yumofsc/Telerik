using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BishopPathFinder
{
    static void Main()
    {
        long r = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long[,] chessBoard = new long[r,c];
        long N = long.Parse(Console.ReadLine());
        long D = int.Parse(Console.ReadLine());
        long K = int.Parse(Console.ReadLine());

        long sum = N + D + K;
        Console.WriteLine(sum);
    }
}

