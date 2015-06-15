using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    class ShowCartUI : IShowUI
    {
        private const int QuantityPadding = 8;
        private const int PricePadding = 8;
        private const int ProductPadding = 24;
        private Cart cart;

        public ShowCartUI(Cart cart)
        {
            this.cart = cart;
        }

        public void Run(IUserInterface userInterface)
        {
            userInterface.Clear();

            if (cart == null || !cart.Items.Any())
            {
                userInterface.WriteLine("Nothing in cart");
            }
            else
            {
                userInterface.WriteLine("Total: ${0}", cart.Price);

                userInterface.WriteLine();
                userInterface.WriteLine("{0} {1} {2}",
                        "Product".PadRight(ProductPadding),
                        "Quantity".PadLeft(QuantityPadding),
                        "Total".PadLeft(PricePadding));

                foreach (var item in cart.Items)
                {
                    userInterface.WriteLine("{0} {1} {2}",
                        item.Product.Name.PadRight(ProductPadding),
                        item.Quantity.ToString().PadLeft(QuantityPadding),
                        item.Price.ToString().PadLeft(PricePadding));
                }
            }

            userInterface.WriteLine();
            userInterface.WriteLine();
        }
    }
}
