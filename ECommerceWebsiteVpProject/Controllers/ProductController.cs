using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;

namespace ECommerceWebsiteVpProject.Controllers
{
    public class ProductController : Controller
    {
        private WebsiteEntities db = new WebsiteEntities();
        
        public ActionResult Index()
        {
            ViewBag.listProducts = db.products.ToList();
            return View();
        }
	}
}