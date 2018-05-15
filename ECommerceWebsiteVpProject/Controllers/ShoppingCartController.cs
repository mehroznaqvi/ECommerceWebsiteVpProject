using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;
namespace ECommerceWebsiteVpProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private WebsiteEntities db = new WebsiteEntities();

        //
        // GET: /ShoppingCart/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderNow(int id)
        {
            if(Session["Cart"]==null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.products.Find(id), 1));
                Session["cart"] = cart;

            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                cart.Add(new Item(db.products.Find(id), 1));
                Session["cart"] = cart;
            }
            return View("cart");

        }
	}
}