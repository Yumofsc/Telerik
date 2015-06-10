using System;
using System.Text;
class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string encodingText = Console.ReadLine();
        long sum = 0;
        decimal finalSum = 0;

        for (int i = 0; i < encodingText.Length; i++)
        {
            long charText = encodingText[i];
            if (charText != '@')
            {
                if (charText >= 'A' && charText <= 'Z' || 'a' <= charText && charText <= 'z')
                {
                    sum = charText * salt + 1000;

                }
                else if (charText >= '0' && charText <= '9')
                {
                    sum = charText + salt + 500;
                }
                else
                {
                    sum = charText - salt;
                }
            }
            else
            {
                return;
            }
            if (i % 2 != 0)
            {
                finalSum = sum * 100m;
                Console.WriteLine("{0}", finalSum);
            }
            else
            {
                finalSum = sum / 100m;
                Console.WriteLine("{0:F2}", finalSum);
            }
        }
    }
}
