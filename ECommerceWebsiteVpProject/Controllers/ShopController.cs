using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;
using System.Text;

namespace ECommerceWebsiteVpProject.Controllers
{
    public class ShopController : Controller
    {
        private WebsiteEntitiesDB db = new WebsiteEntitiesDB();

        public ActionResult Index()
        {
            List<product> list = db.products.ToList();
            return View(list);
        }


        public ActionResult SaveData(string name, string price, string picture)
        {
            product obj = new product();
            obj.pName = name;
            obj.pPrice = price;
            obj.pImage = picture;
            db.products.Add(obj);
            db.SaveChanges();
            return View();
            

        }
	}
}