using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ECommerceWebsiteVpProject.Models;

namespace ECommerceWebsiteVpProject.OnlineShopData
{
    public class OnlineShopData:DbContext
    {
        public OnlineShopData() : base("OnlineShopData")
        {}
        public DbSet<shop> Product { get; set; }
            
    }
}