using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;

namespace ECommerceWebsiteVpProject.Controllers
{
    public class LoginController : Controller
    {
        WebsiteEntitiesDB db = new WebsiteEntitiesDB();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult login(string em, string pass)
        {
            var response = false;
            DataChecckDataContext authentication = new DataChecckDataContext();
           var checking_email = authentication.Logins.Where(s => s.username.Equals(em) && s.password.Equals(pass)).FirstOrDefault();
           if(checking_email!=null)
           {
               response = true;
               Session["UserID"] = em;
           }
               
               //var checking_email = from email in db.RegisterUsers where email.userEmail.Equals(em) select email.userEmail;
            //Console.WriteLine(checking_email);
            //var checking_password = from password in db.RegisterUsers where reg.userPassword.Equals(pass) select password;

            //var email = from db in obj.userEmail where em == obj.userEmail select db;
           return Json(response);
        }

        
	}
}