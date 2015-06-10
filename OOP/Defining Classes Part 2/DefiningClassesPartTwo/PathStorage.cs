namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    //Create a static class PathStorage with static methods to save and load paths from a text file.
    //Use a file format of your choice.
    public static class PathStorage
    {
        private static List<Path> pathes = new List<Path>();
        public static List<Path> Pathes
        {
            get { return pathes; }
            set { pathes = value; }
        }
	
        public static void LoadPaths()
    }
}
