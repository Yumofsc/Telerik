using System;
class Tribonacci
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secoundNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int answer = 0;

        if (firstNumber == 0)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secoundNumber == 0)
        {
            Console.WriteLine(secoundNumber);
        }
        else if (thirdNumber == 0)
        {
            Console.WriteLine(thirdNumber);
        }
        else
        {
            for (int i = 3; i < l; i++)
            {
                answer = firstNumber + secoundNumber + thirdNumber;
                firstNumber = secoundNumber;
                secoundNumber = thirdNumber;
                thirdNumber = answer;
            }
            Console.WriteLine(answer);
        }
    }
}
