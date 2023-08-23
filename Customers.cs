using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE
{
    public class Customers
    {
        public Customers(){
            Order = new List<Orders>();
        }
        public int Id {get; set;}
        public string FiratName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        public string Address {get; set;}
        public List<Orders> Order {get; set;}
    }
}