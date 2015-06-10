//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//    If the score is between 1 and 3, the program multiplies it by 10.
//    If the score is between 4 and 6, the program multiplies it by 100.
//    If the score is between 7 and 9, the program multiplies it by 1000.
//    If the score is 0 or more than 9, the program prints “invalid score”.

using System;
class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter your score:");
        double score = double.Parse(Console.ReadLine());
        if (1 <= score && score <= 9)
        {
            Console.WriteLine("Congratilations !!! You have a bonus");

            if (1 <= score && score <= 3)
            {
                score *= 10;
                Console.WriteLine("Your total score (score + bonus) is: {0}", score);
            }
            else if (4 <= score && score <= 6)
            {
                score *= 100;
                Console.WriteLine("Your total score (score + bonus) is: {0}", score);
            }
            else if (7 <= score && score <= 9)
            {
                score *= 1000;
                Console.WriteLine("Your total score (score + bonus) is: {0}", score);
            }
        }
        else 
        {
            Console.WriteLine("Invalid Score");
        }
    }
}
