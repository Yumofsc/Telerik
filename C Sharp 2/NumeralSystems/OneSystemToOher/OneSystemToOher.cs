using System;

//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
class OneSystemToOher
{
    static void Main()
    {
        //long decNumber = long.Parse(Console.ReadLine());
        //Console.WriteLine("Enter numeral system");
        //int numeralSystem = int.Parse(Console.ReadLine());
        //Console.WriteLine(DecimalToBase(decNumber, numeralSystem));
        string baseNumber = Console.ReadLine();
        int decimalSystem = int.Parse(Console.ReadLine());
        Console.WriteLine(BaseToDecimal(baseNumber, decimalSystem));

    }
    static string DecimalToBase(long decNumber, int numeralSystem)
    {
        string result = "";
        while (decNumber > 0)
        {
            long digit = decNumber % numeralSystem;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decNumber /= numeralSystem;
        }
        return result;
    }
    static long BaseToDecimal(string baseNumber, int decimalSyestem)
    {
        long decimalNumber = 0;
        for (int i = 0; i < baseNumber.Length; i++)
        {
            long digit = 0;
            if (baseNumber[i] >= 0 && baseNumber[i] <= 9)
            {
                 digit = baseNumber[i] + '0';
            }
            else if (baseNumber[i] >= 10 && baseNumber[i] <= 36)
            {
                 digit = baseNumber[i] - 10 + 'A';
            }
            var position = baseNumber.Length - i - 1;
            decimalNumber = digit * (long)Math.Pow(decimalSyestem, position);
        }
        return decimalNumber;
    }
}

