using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Program
{
    static void Main()
    {
        string text = Console.ReadLine()
             .Replace("CHU", "0")
.Replace("TEL", "1")
.Replace("OFT", "2")
.Replace("IVA", "3")
.Replace("EMY", "4")
.Replace("VNB", "5")
.Replace("POQ", "6")
.Replace("ERI", "7")
.Replace("CAD", "8")
.Replace("K-A", "9")
.Replace("IIA", "A")
.Replace("YLO", "B")
.Replace("PLA", "C");
        


        BigInteger result = 0;
        int power = 0;

        for (int i = text.Length - 1; i >= 0; i--)
        {
            int number = 0;
            if (text[i] >= '0' && text[i] <= '9')
            {
                number = text[i] - '0';
            }
            else if (text[i] >= 'A' && text[i] <= 'C')
            {
                number = text[i] - 'A' + 10;
            }
            
            result += number * Power(13, power);
            power++;
        }
        Console.WriteLine(result);


        
    }
    static BigInteger Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}

