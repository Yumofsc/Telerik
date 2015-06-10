using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblem
{
    class MathProblem
    {
        static void Main()
        {
            string fullCatText = Console.ReadLine();
            string[] catText = fullCatText.Split(' ');

            long sum = 0;

            foreach (var item in catText)
            {

                long result = 0;
                long power = 0;
                for (int i = item.Length - 1; i >= 0; i--)
                {

                    long digit = item[i] - 'a';

                    result += digit * Power(19, power);
                    power++;

                }

                sum += result;
            }

            Console.WriteLine(DecimalTo19th(sum) + " = " + sum);

        }
        static string DecimalTo19th(long decNumber)
        {
            string nineteenNumber = "";
            while (decNumber > 0)
            {
                long digit = decNumber % 19;
                nineteenNumber = (char)(digit + 'a') + nineteenNumber;
                decNumber /= 19;
            }

            return nineteenNumber;
        }
        static long Power(long number, long power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
