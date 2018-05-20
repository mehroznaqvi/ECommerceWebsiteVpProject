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

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(ShopModelView shopModelView)
        {
            WebsiteEntities2 db = new WebsiteEntities2();
            return View();
            

        }
	}
}