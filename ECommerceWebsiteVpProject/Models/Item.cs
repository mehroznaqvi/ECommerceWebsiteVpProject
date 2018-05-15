using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebsiteVpProject.Models
{
    public class Item
    {
        private product pr = new product();

        public product Pr
        {
            get { return pr; }
            set { pr = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Item()
        { }
        public Item(product pro, int quantity)
        {
            this.pr = pro;
            this.quantity = quantity;
        }
    }
}