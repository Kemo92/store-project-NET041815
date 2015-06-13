using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreProject.UI.MvcApplication.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View(ApplicationContext.Cart);
        }

        [HttpPost]
        public ActionResult Add(string id, int quantity)
        {
            var product = ApplicationContext.Store.FindProduct(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            ApplicationContext.Cart.Add(product, quantity);

            return RedirectToAction("Index", "Products");
        }
    }
}