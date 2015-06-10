namespace Shapes
{
    using System;
    //Define two new classRectangle that implement the 
    //virtual method and return the surface of the figure (height * width).
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width,height)
        {

        }
        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
