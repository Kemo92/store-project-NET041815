using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.Core
{
    /// <summary>
    /// Represents a product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Constructor that creates a product from a name, sku, and price
        /// </summary>
        /// <param name="name">Name of the product</param>
        /// <param name="sku">Stock keeping unit of the product</param>
        /// <param name="price">Price of the product</param>
        public Product(string name, string sku, decimal price)
        {
            Name = name;
            Sku = sku;
            Price = price;
        }

        /// <summary>
        /// Get the name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Get the stock keeping unit
        /// </summary>
        public string Sku { get; private set; }

        /// <summary>
        /// Get the price
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// Gets a string representation of the product
        /// </summary>
        public override string ToString()
        {
            return string.Format("({0}) {1}: {2}", Sku, Name, Price);
        }
    }
}
