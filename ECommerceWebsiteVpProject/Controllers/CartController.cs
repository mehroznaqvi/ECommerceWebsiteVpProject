using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;

namespace ECommerceWebsiteVpProject.Controllers
{
    public class CartController : Controller
    {
        private product db = new product();
        public ActionResult Index()
        {
            return View();
        }
	}
}