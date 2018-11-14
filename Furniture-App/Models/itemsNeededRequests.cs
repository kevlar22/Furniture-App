using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.Models
{
    public class itemNeedRequests
    {
        public int requestId { get; set; }
        public int userId { get; set; }
        public string category { get; set; }
        public int minPrice { get; set; }
        public int maxPrice { get; set; }
    }
}
