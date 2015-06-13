using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Core
{
    public class CartItem
    {
        public CartItem(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException();
            else
            {
                Product = product;
                Quantity = quantity;
            }
        }

        public Product Product { get; private set; }

        public int Quantity { get; private set; }

        public decimal Price
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public void ChangeQuantityBy(int quantity)
        {
            Quantity += quantity;

            if (Quantity <= 0)
            {
                Quantity = 0;
            }
        }
    }
}
