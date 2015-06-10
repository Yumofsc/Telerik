namespace DefiningClassesPartTwo
{
    using System;
    public static class Distance
    {
        // d = sqrt [(x2 - x1)^2 + (y2 - y1)^2 + (z1 - z2)^2]
        public static decimal DistanceBetween2Points(Point3D pointOne, Point3D pointTwo)
        {
            decimal distance = 0;
            double firstArgument = Math.Pow(pointTwo.X - pointOne.X, 2);
            double secondArgument = Math.Pow(pointTwo.Y - pointOne.Y, 2);
            double thirdArgument = Math.Pow(pointTwo.Z - pointOne.Z, 2);

            distance = (decimal)Math.Sqrt(firstArgument + secondArgument + thirdArgument);

            return distance;
        }
    }
}
