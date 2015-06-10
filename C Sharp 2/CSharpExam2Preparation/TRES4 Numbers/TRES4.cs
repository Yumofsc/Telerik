using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TRES4
{
    static void Main()
    {
        //ulong numSystem = 9;
        ulong decNumber = ulong.Parse(Console.ReadLine());
        string[] digits = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        StringBuilder result = new StringBuilder();
        do
        {
            ulong nineNumber = decNumber % 9;
            result.Insert(0, digits[nineNumber]);
            decNumber /= 9;
        }
        while (decNumber > 0);
        Console.WriteLine(result.ToString());


        
        
    }

}







