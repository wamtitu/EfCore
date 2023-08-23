using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public string Product { get; set; }="";
        public int totalAmount { get; set; }
        public Customers? Customer { get; set; }
        public int Id { get; set; }
        
    }
}