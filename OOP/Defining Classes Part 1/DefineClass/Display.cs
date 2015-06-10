using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Define a class that holds information about a display characteristics (size and number of colors).

namespace GSMMain
{
    public class Display
    {
        private double size;
        private int colorsNumber;

      
        public Display(double displaySize, int displayColors)
        {
            this.Size = displaySize;
            this.ColorsNumber = displayColors;
        }

        public double Size
        {
            get { return this.size; }
            set 
            {
                if (size < 0)
                {
                    throw new IndexOutOfRangeException("Size must not be negative");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public int ColorsNumber
        {
            get { return this.colorsNumber; }
            set 
            {
                if (colorsNumber < 0)
                {
                    throw new IndexOutOfRangeException("The number of colors must not be negative");
                }
                else
                {
                    this.colorsNumber = value;
                }
            }
        }
        public override string ToString()
        {
            return this.size + " " + this.colorsNumber;
        }
    }
}
