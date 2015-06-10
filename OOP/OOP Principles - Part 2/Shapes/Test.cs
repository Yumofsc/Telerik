/*Problem 1. Shapes

Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the 
    virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
Define class Square and suitable constructor so that at initialization 
    height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method
    for different shapes (Square, Rectangle, Triangle) stored in an array. */

namespace Shapes
{
    using System;
    using System.Collections.Generic;
    public class Test
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(3, 5);
            Rectangle rectangle = new Rectangle(5, 8);
            Square square = new Square(4);
            Shape[] figures = new Shape[] { triangle, rectangle, square };

            foreach (Shape figure in figures)
            {
                Console.WriteLine("Area of the {0} is {1}", figure.ToString(), figure.CalculateSurface());
            }
        }
    }
}
