//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter value for \"x\"");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for \"y\"");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Is the Point Inside a Circle and Outside of a Rectangle?");

        bool inCircle = (Math.Sqrt((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5);
        bool outOfRectngle = x > 1 && x <= 5 && y > -1 && y <= 1;
        if (inCircle && !outOfRectngle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
