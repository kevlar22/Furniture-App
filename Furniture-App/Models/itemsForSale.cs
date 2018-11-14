using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.Models
{
    public class itemsForSale
    {
      
            public int itemID { get; set; }
            public int userID { get; set; }
            public string name { get; set; }
            public int price { get; set; }
            public string description { get; set; }
            public string image { get; set; }
            public string category { get; set; }
    }
}
