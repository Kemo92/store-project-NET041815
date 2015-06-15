using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreProject.UI.MvcApplication.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View(ApplicationContext.Store.AllProducts());
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var product = ApplicationContext.Store.FindProduct(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}