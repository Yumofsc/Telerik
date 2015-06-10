namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    public class Categorie : ICategory
    {
        private string categoryName;
        private bool notFound;
        private ICollection<IProduct> productsList;


        //Minimum category name’s length length is 2 symbols and maximum is 15 symbols. The error message should be "Category name must be between {min} and {max} symbols long!". 
        public Categorie(string cosmeticName)
        {
            this.Name = cosmeticName;
            this.productsList = new List<IProduct>();

        }
        public string Name
        {
            get
            {
                return this.categoryName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty!");
                }
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Category name must be between {min} and {max} symbols long!");
                }
                this.categoryName = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            productsList.Add(cosmetics);
            productsList.OrderBy(p => p.Brand)
                        .ThenByDescending(p => p.Price);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            productsList.Remove(cosmetics);
            if (notFound)
            {
                throw new ArgumentException("Product {0} does not exist in category {1}!", categoryName);
            }
        }

        public string Print()
        {
            /* Category’s print method should return text in the following format:
{category name} category – {number of products} products/product in total
- {product brand} – {product name}:
  * Price: ${product price}
  * For gender: Men/Women/Unisex
  * Ingredients: {product ingredients, separated by “, “} (when applicable)
- {product brand} – {product name}:
  * Price: ${product price}
  * For gender: {product gender}
  * Quantity: {product quantity} ml (when applicable)
  * Usage: EveryDay/Medical (when applicable)
*/
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("{0} category", this.Name));
            if (productsList.Count == 1)
            {
                sb.Append(string.Format(" – {1} product in total", productsList.Count));
            }
            else
            {
                sb.Append(string.Format(" – {1} products in total", productsList.Count));
            }
            sb.AppendLine(Print());

            return sb.ToString().Trim();
        }

    }
}
