using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWebsiteVpProject.Models;
using System.Text;


namespace ECommerceWebsiteVpProject.Controllers
{
    public class RegisterUserController : Controller
    {
        private WebsiteEntitiesDB obj = new WebsiteEntitiesDB();
        public ActionResult Index()
        {
            List<RegisterUser> list = obj.RegisterUsers.ToList();
            return View(list);
        }

        public ActionResult Registeration(string fName, string lName, string userAddress, string userCountry, string userProvience, string userCity, string userPostelcode, string userEmail, string userPhone, string userPassword)
        {
            RegisterUser db = new RegisterUser();
            db.userFirstName = fName;
            db.userLastName = lName;
            db.userAddress = userAddress;
            db.userCountry = userCountry;
            db.userProvience = userProvience;
            db.userCity = userCity;
            db.userPostelcode = userPostelcode;
            db.userEmail = userEmail;
            db.userPhone = userPhone;
            db.userPassword = userPassword;
            obj.RegisterUsers.Add(db);
            obj.SaveChanges();
            return View();
        }
        public ActionResult login(string user, string pass)
        {
           

            return View();
        }

    }
}