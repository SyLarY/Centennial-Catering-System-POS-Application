using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centennial_Catering_System
{
    class Categories
    {
        public Categories(string categoryID, string cd)
        {
            CategoryID = categoryID;
            CategoryDescription = cd;
        }

        public string CategoryID { get; set; }
        public string CategoryDescription { get; set; }
    }
}
