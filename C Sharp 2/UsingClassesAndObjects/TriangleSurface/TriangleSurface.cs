using System;

//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
//Example:

//input	                    |   output
//* a = 23.2, h = 5	        |   58
//* a = 11, b =12, c = 13	|   61.48
//* a = 10, b = 7, C = 25°  |   14.79
class TriangleSurface
{
    static void Main()
    {

        //Console.WriteLine("Calculate the surface of a triangle: ");
        //Console.WriteLine("1. For method with given Side and an Altitude );
        ConsoleKeyInfo button;
        Console.WriteLine("Calculate the surface of a triangle:");
        Console.WriteLine("1.For method with given Side and an Altitude to it, press\"1\"!");
        Console.WriteLine("2.For method with given Three sides, press\"2\"!");
        Console.WriteLine("3.For method with given Two sides and an angle between them, press\"3\"!");
        Console.WriteLine();
        button = Console.ReadKey();
        if (button.Key == ConsoleKey.D1)
        {
            Console.WriteLine(" Enter SIDE \"a\" of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter HEIGHT \"h\" of a triangle: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(" The AREA of the triangle is: {0:F2}", SideAndAltitude(a, h));
        }
        if (button.Key == ConsoleKey.D2)
        {
            Console.WriteLine(" Enter SIDE \"a\" of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter SIDE \"b\" of a triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter SIDE \"c\" of a triangle: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(" The AREA of the triangle is: {0:F2}", ThreeSides(a, b, c));
        }
        if (button.Key == ConsoleKey.D3)
        {
            Console.WriteLine(" Enter SIDE \"a\" of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter SIDE \"b\" of a triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter ANGLE \"Alpha\" of a triangle: ");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine(" The AREA of the triangle is: {0:F2}", TwoSidesAndAngle(a, b, angle));
        }
    }
    static double SideAndAltitude(double a, double h)
    {
        double area = 0;
        area = (a * h) / 2;

        return area;
    }
    static double ThreeSides(double a, double b, double c)
    {
        // calculateing using Heron's Formula:
        double area = 0;
        double halfPerimeter = (a + b + c) / 2;
        area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

        return area;
    }
    static double TwoSidesAndAngle(double a, double b, double angle)
    {
        //double angle    = Math.PI * degrees / 180.0;
        //double sinAngle = Math.Sin(angle);

        //Using "side angle side" (SAS) method
        
        double area = 0;
        double degreeAngle = Math.PI * angle / 180.0;
        area = (a * b * Math.Sin(degreeAngle)) / 2;

        return area;
    }
}