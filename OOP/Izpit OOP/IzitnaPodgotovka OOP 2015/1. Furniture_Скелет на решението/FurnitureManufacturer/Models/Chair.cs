namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;
   public class Chair : Furniture, IChair, IFurniture
    {
       
       public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
           : base(model,material,price,height)
       {
           this.NumberOfLegs = numberOfLegs;
       }
       public int NumberOfLegs { get; private set; }
       public override string ToString()
       {
           
           
           return base.ToString() + string.Format(", Legs: {0}",this.NumberOfLegs);
           
       }
    }
}
