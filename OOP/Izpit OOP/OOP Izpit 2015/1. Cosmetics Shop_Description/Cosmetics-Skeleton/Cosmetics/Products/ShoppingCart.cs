

namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> shoppingCart;

        public void AddProduct(IProduct product)
        {
            shoppingCart.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            shoppingCart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (shoppingCart.Contains(product))
            {
                return true;
            }
            return false;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
           
            foreach (var product in shoppingCart)
            {
               totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
