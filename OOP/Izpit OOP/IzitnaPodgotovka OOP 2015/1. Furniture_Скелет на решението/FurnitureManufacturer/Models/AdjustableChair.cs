namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;
    class AdjustableChair : Chair, IAdjustableChair, IFurniture
    {
        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs)
           : base(model,material,price,height,numberOfLegs)
    {

    }
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}
