namespace Shapes
{
    public class Square : Shape
    {
        public Square(double size)
            : base(size,size)
        {

        }
        public override double CalculateSurface()
        {
            double surface = this.Width * this.Width;
            return surface;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
