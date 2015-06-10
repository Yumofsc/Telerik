namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;
    

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;
        
        

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.Material = material;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The furniture model can not be null or empty");
                }
                if (this.model.Length < 3)
                {
                    throw new ArgumentException("The length can not be less three symbols");
                }
                this.model = value;
            }
        }

        public string Material { get; private set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be less or equal to 0.");
                }
                this.price = value;
            }
        }

        public  virtual decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be less or equal to 0.");
                }
                this.height = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
