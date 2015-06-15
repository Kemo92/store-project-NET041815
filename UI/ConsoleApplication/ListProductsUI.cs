using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    public class ListProductsUI : IShowUI
    {
        private Store store;

        public ListProductsUI(Store store)
        {
            this.store = store;
        }

        public void Run(IUserInterface userInterface)
        {
            foreach (var product in store.AllProducts())
            {
                userInterface.WriteLine(product);
            }
        }
    }
}
