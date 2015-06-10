using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisibleBy7and3
{
    class DevisibleBy7and3
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7, 14, 21, 42, 62, 63 };
            var devisibled = from number in arr
                             where number % 3 == 0 && number % 7 == 0
                             select number;

            Console.WriteLine("NUMBERS DEVISIBLE BY 7 AND 3: (using LINQ)");
            Console.WriteLine(string.Join(" ", devisibled));

            Console.WriteLine("NUMBERS DEVISIBLE BY 7 AND 3 (using Lambda):");
            int[] devisibled2 = arr.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();
            Console.WriteLine(string.Join(" ", devisibled2));
        }
    }
}
