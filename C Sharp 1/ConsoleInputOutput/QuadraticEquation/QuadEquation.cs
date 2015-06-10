//using System;
//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
//(prints its real roots).

using System;
class QuadEquation
{
    static void Main()
    {
        Console.WriteLine("Pleace enter coefficient \"a\":");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Pleace enter coefficient \"b\":");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Pleace enter coefficient \"c\":");
        double c = double.Parse(Console.ReadLine());
        double d = Math.Pow(b, 2) - 4 * (a * c);
        if (a != 0)
        {
            Console.WriteLine("the Equation has solution!");

            if (d > 0)
            {
                Console.WriteLine("the Equation has two roots ");
                double x1 = (-b + (Math.Sqrt(d)) / (a * 2));
                double x2 = (-b - (Math.Sqrt(d)) / (a * 2));
                Console.WriteLine("\"x1\" = {0} and\"x2\" = {1}", x1, x2);
            }
            else if (d == 0)
            {
                Console.WriteLine("the Equation has one roots!");
                double x1 = (-b / (a * 2));
                Console.WriteLine("\"x\" = {0}", x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("the Equation has no real roots ");
            }
        }
        else
        {
            Console.WriteLine("the Equation has NO solution!");
        }
    }
}

