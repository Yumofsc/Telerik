namespace Shapes
{
    //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width can not be negative number or zero");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height can not be negative number or zero");
                }
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
    }
}
