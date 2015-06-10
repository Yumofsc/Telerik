namespace Shapes
{
    //Define two new class Triangle that implement the 
    //virtual method and return the surface of the figure (height * width/2).
    using System;

    public class Triangle : Shape
    {
        public Triangle(double width, double height)
           : base(width,height)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (this.Height * this.Width)/2;
            return surface;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
