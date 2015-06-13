using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Core
{
    public class Cart
    {
        private IList<CartItem> items = new List<CartItem>();

        public void Add(Product product, int quantity)
        {
            var item = items.SingleOrDefault(x => x.Product == product);

            if (product == null)
                throw new ArgumentNullException();

            if (item == null && quantity > 0)
            {
                items.Add(new CartItem(product, quantity));
            }
            else if (item != null)
            {
                item.ChangeQuantityBy(quantity);

                if (item.Quantity == 0)
                {
                    items.Remove(item);
                }
            }
        }

        public IEnumerable<Product> Products
        {
            get
            {
                return items.Select(y => y.Product);
            }
        }

        public decimal Price
        {
            get
            {
                return items.Sum(x => x.Price);
            }
        }
    }
}
