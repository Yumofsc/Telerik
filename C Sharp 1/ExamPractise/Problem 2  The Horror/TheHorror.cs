using System;
class TheHorror
{
    static void Main()
    {
        string digits = Console.ReadLine();
        ulong number = 0;
        ulong sum = 0;
        int counter = 0;


        for (int i = 0; i < digits.Length; i++)
        {
            char symbol = digits[i];
            number = (ulong)(symbol - '0');
            if (i % 2 == 0)
            {
                if (symbol <= '0' && symbol <= '9')
                {
                    sum = number + sum;
                }
                sum = number + sum;
                counter++;
            }
        }
        Console.WriteLine(counter+ " " +sum);
    }
}