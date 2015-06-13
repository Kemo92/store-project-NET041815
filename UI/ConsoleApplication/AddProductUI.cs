using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    class AddProductUI
    {
        private Store store;
        private Cart cart;

        public AddProductUI(Store store, Cart cart)
        {
            this.store = store;
            this.cart = cart;
        }

        internal void Run()
        {
            var product = GetProductFromUser();

            if (product != null)
            {
                var quantity = GetQuantityFromUser();

                if (quantity.HasValue)
                {
                    cart.Add(product, quantity.Value);
                }
            }
        }

        private int? GetQuantityFromUser()
        {
            while (true)
            {
                Console.Write("Enter quantity (m to return to main menu): ");
                var input = Console.ReadLine().Trim();
                if (input == "m")
                {
                    return null;
                }

                int value = 0;
                if (int.TryParse(input, out value))
                {
                    return value;
                }
            }
        }

        private Product GetProductFromUser()
        {
            while (true)
            {
                Console.Write("Enter product sku: ");
                var sku = Console.ReadLine().Trim();

                var product = store.FindProduct(sku);
                
                if (product == null)
                {
                    Console.WriteLine("Didn't find a product.");
                    Console.WriteLine("s) Search again");
                    Console.WriteLine("m) Main menu");

                    var input = Console.ReadLine().Trim();
                    if (input == "m")
                    {
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Found {0}", product);
                    Console.WriteLine("c) Choose quantity");
                    Console.WriteLine("s) Search again");
                    Console.WriteLine("m) Main menu");

                    var input = Console.ReadLine().Trim();
                    if (input == "m")
                    {
                        return null;
                    }
                    else if (input == "c")
                    {
                        return product;
                    }
                }
            }
        }
    }
}
