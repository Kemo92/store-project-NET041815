using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    class AddProductUI : IShowUI
    {
        private Store store;
        private Cart cart;

        public AddProductUI(Store store, Cart cart)
        {
            this.store = store;
            this.cart = cart;
        }

        public void Run(IUserInterface userInterface)
        {
            var product = GetProductFromUser(userInterface);

            if (product != null)
            {
                var quantity = GetQuantityFromUser(userInterface);

                if (quantity.HasValue)
                {
                    cart.Add(product, quantity.Value);
                }
            }
        }

        private int? GetQuantityFromUser(IUserInterface userInterface)
        {
            while (true)
            {
                Console.Write("Enter quantity (m to return to main menu): ");
                var input = userInterface.GetChoice();
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

        private Product GetProductFromUser(IUserInterface userInterface)
        {
            while (true)
            {
                Console.Write("Enter product sku: ");
                var sku = Console.ReadLine().Trim();

                var product = store.FindProduct(sku);
                
                if (product == null)
                {
                    userInterface.WriteLine("Didn't find a product.");
                    userInterface.WriteLine("s) Search again");
                    userInterface.WriteLine("m) Main menu");

                    var input = userInterface.GetChoice();
                    if (input == "m")
                    {
                        return null;
                    }
                }
                else
                {
                    userInterface.WriteLine("Found {0}", product);
                    userInterface.WriteLine("c) Choose quantity");
                    userInterface.WriteLine("s) Search again");
                    userInterface.WriteLine("m) Main menu");

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
