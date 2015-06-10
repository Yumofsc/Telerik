namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;
    
    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private ICollection<string> ingredients;
        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand ,price, gender)
        {
            this.ingredients = ingredients;
        }
        public string Ingredients 
        { 
            get
            {
                return string.Join(", ", ingredients.ToString());
            }
        }
       
        public override string Print()
        {
            // * Ingredients: {product ingredients, separated by “, “} (when applicable)
            var sb = new StringBuilder(Print());

            sb.AppendLine(string.Format("* Ingredients: {0}", this.Ingredients));

            return sb.ToString().Trim();
        }
    }
}
