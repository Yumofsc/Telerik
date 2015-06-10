namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    using System.Text;
   
    public class Table : Furniture, ITable, IFurniture
    {
        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            : base(model,material,price,height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }
        public decimal Area
        {
            get
            {
                return this.Length * this.Height;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
        }
    }
}
