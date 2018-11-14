using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.Models
{
    public class address
    {
        public string userID { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string aptNum { get; set; }
    }
}
