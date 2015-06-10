//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Type the points to check them \nAre they them in the circle?");
        double r = 2;
        double x = 0;
        double y = 0;

        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double a = Math.Pow(( x1-x ), 2);
        double b = Math.Pow(( y1-y ), 2);
        double c = Math.Pow(r , 2);
        double result = a + b;
        bool isTrue = result <= c;
        Console.WriteLine("The result is:");
        Console.WriteLine(isTrue);
    }
}
