using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreProject.UI.MvcApplication
{   
    static public class ApplicationContext
    {
        static ApplicationContext()
        {
            Store = new Store();
            Cart = new Cart();
        }

        public static Store Store { get; set; }

        public static Cart Cart { get; set; }
    }
}