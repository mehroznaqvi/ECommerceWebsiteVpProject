using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ECommerceWebsiteVpProject.Models;

namespace ECommerceWebsiteVpProject.OnlineShopData
{
    public class DataContextInitializer:DropCreateDatabaseIfModelChanges<OnlineShopData>
    {
        protected override void Seed(OnlineShopData context)
        {
            var products = new List<product>();
            {
                new product() { pName = "product11", pPrice = "1000", pDateCreation = "2018-22-6" };
            };

        }
    }
}