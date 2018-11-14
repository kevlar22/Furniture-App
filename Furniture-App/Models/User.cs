using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.Models
{
        public class User
        {
            public int userID { get; set; }
            public string userName { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }

            public ICollection<address> addresses { get; set; }
            public ICollection<itemsForSale> itemsForSales { get; set; }
            public ICollection<itemNeedRequests> itemNeedRequests { get; set; }
            
        }
}
