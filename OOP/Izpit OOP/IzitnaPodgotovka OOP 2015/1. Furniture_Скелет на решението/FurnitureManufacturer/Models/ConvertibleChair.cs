namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class ConvertibleChair : Chair, IConvertibleChair, IFurniture
    {
        private const decimal ConvertedHight = 0.10m;
        private bool isConverted;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model,material,price,height,numberOfLegs)
        {
        }
        public bool IsConverted
        {
            get 
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }
        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return this.Height = ConvertedHight;
                }
                return base.Height;
            }
            set
            {
                base.Height = value;
            }
        }
        public override string ToString()
        {
           
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}

