using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category {get; set;}
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
