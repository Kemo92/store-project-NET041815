using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    class ListProductsUI
    {
        private Store store;

        public ListProductsUI(Store store)
        {
            this.store = store;
        }

        internal void Run()
        {
            foreach (var product in store.AllProducts())
            {
                Console.WriteLine(product);
            }
        }
    }
}
