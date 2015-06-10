namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    public class Shampoo : Product, IProduct, IShampoo
    {
        private decimal shampooPrice;
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name,brand,price,gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.shampooPrice = this.Price * this.Milliliters;
        }
        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override string Print()
        {
            //* Quantity: {product quantity} ml (when applicable)
            //* Usage: EveryDay/Medical (when applicable)

            StringBuilder sb = new StringBuilder(base.Print());

            sb.AppendLine(string.Format("{0} ml", this.Milliliters));
            sb.AppendLine(string.Format("* Usage: {0}", this.Usage));

            return sb.ToString().Trim();
        }
    }
}
