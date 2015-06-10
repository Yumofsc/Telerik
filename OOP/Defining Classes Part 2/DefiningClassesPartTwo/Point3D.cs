namespace DefiningClassesPartTwo
{
    using System;
    


    public struct Point3D
    {
        private static readonly Point3D point0;

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        static Point3D()
       {
           point0 = new Point3D(0, 0, 0);
       }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
       static Point3D Point0
       {
           get
           {
               return point0;
           }
       }

       public override string ToString()
       {
           return string.Format("The coordinates of the point are: {0}, {1}, {2}", this.X, this.Y,this.Z);
       }
    }

}
