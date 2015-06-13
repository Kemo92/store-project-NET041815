using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.Core
{
    /// <summary>
    /// Represents a store
    /// </summary>
    public class Store
    {
        private IList<Product> products;

        /// <summary>
        /// Constructor that initializes default values
        /// </summary>
        public Store()
        {
            products = new List<Product>
            {
                new Product("knife", "KN123", 12.95m),
                new Product("NVidia 970", "NV970", 320.99m)
            };
        }

        /// <summary>
        /// Gets a list off all the products in the store
        /// </summary>
        public IEnumerable<Product> AllProducts()
        {
            return products;
        }

        public Product FindProduct(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return null;
            }

            return products.FirstOrDefault(x => x.Sku.ToLower().Contains(searchTerm.ToLower()));
        }
    }
}
