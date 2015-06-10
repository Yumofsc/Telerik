//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and .

using System;
class DrawRectangles
{
    static void Main()
    {
        Console.WriteLine("Type rectangle width :");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Type rectangle height :");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle’s Perimeter is :");
        Console.WriteLine((width + height) * 2);
        Console.WriteLine("Rectangle’s Area is :");
        Console.WriteLine(width * height);


    

    }
}


