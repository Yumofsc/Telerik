namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    class TestMain
    {
        static void Main()
        {
            var pointOne = new Point3D(5, 6, 7);
            var pointTwo = new Point3D(1, 2, 3);
            Console.WriteLine(pointOne + "\n" + pointTwo);

            Console.WriteLine();
            Path firstPath = new Path();
            Path secoundPath = new Path();
            firstPath.Sequence.Add(pointOne);
            secoundPath.Sequence.Add(pointTwo);

            Console.WriteLine(firstPath + "\n"+secoundPath);
            Console.WriteLine();
            Console.WriteLine(Distance.DistanceBetween2Points(pointTwo,pointOne));

        }
    }
}
