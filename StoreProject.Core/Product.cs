using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.Core
{
    public class Product
    {
        public Product(string name, string sku, decimal price)
        {
            Name = name;
            Sku = sku;
            Price = price;
        }

        public string Name { get; private set; }

        public string Sku { get; private set; }

        public decimal Price { get; private set; }

        public override string ToString()
        {
            return string.Format("({0}) {1}: {2}", Sku, Name, Price);
        }
    }
}
