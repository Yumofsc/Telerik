namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        public string Name
        {
            //Minimum product name’s length is 3 symbols and maximum is 10 symbols. The error message should be "Product name must be between {min} and {max} symbols long!". 
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be empty or null!");
                }
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Product name must be between 3 and 10 symbols long!");
                }
                this.name = value;
            }
        }
        //Minimum brand name’s length is 2 symbols and maximum is 10 symbols. The error message should be "Product brand must be between {min} and {max} symbols long!".
        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The brand can not be empty or null!");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Product brand must be between 2 and 10 symbols long!");
                }
                this.brand = value;
            }
        }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; private set; }
        public virtual string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1};",this.Brand,this.Name));
            sb.AppendLine(string.Format("* Price: ${0}", this.Price));
            sb.AppendLine(string.Format("* For gender: {0}", this.Gender));

           
            return sb.ToString().Trim();
        }
        /*  - {product brand} – {product name}:
            * Price: ${product price}
            * For gender: Men/Women/Unisex
            * Ingredients: {product ingredients, separated by “, “} (when applicable)

            - Colgate - White+:
            * Price: $15.50
            * For gender: Men
            * Ingredients: fluor, bqla, golqma

         */
    }
}
