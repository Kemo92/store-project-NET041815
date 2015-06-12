using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.Core
{
    public class Store
    {
        private IList<Product> products;

        public Store()
        {
            products = new List<Product>
            {
                new Product("knife", "KN123", 12.95m),
                new Product("NVidia 970", "NV970", 320.99m)
            };
        }

        public IEnumerable<Product> AllProducts()
        {
            return products;
        }
    }
}
