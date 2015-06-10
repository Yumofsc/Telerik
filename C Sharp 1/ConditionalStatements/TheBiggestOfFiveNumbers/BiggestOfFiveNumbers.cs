//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstN = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondN = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdN = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number:");
        double fourthN = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number:");
        double fifthN = double.Parse(Console.ReadLine());

        if (firstN >= secondN && firstN >= thirdN && firstN >= fourthN && firstN >= fifthN)
        {
            Console.WriteLine("The biggest one is {0}", firstN);
        }
        else if (secondN >= firstN && secondN >= thirdN && secondN >= fourthN && secondN >= fifthN)
        {
            Console.WriteLine("The biggest one is {0}", secondN);
        }
        else if (thirdN >= firstN && thirdN >= secondN && thirdN >= fourthN && fifthN >= secondN)
        {
            Console.WriteLine("The biggest one is {0}", thirdN);
        }
        else if (fourthN >= firstN && fourthN >= secondN && fourthN >= thirdN && fourthN >= fifthN)
        {
            Console.WriteLine("The biggest one is {0}", fourthN);
        }
        else if (fifthN >= firstN && fifthN >= secondN && fifthN >= thirdN && fifthN >= fourthN)
        {
            Console.WriteLine("The biggest one is {0}", fifthN);
        }
    }
}
