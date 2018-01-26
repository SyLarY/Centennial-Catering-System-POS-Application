using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centennial_Catering_System
{
    class Items
    {
        public Items(string itemID, string categoryID, string productName, string productImg, double price)
        {
            ItemID = itemID;
            CategoryID = categoryID;
            ProductName = productName;
            ProductImg = productImg;
            Price = price;
        }

        public string ItemID { get; set; }
        public string CategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductImg { get; set; }
        public double Price { get; set; }

    }
}
