﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;


namespace ECommerceWebsiteVpProject.Controllers
{
    public class ShopController : Controller
    {
        private WebsiteEntities db = new WebsiteEntities();
        public ActionResult Index()
        {
            return View();
        }
	}
}