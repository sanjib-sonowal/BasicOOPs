using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public static class Repository
    {
        public static List<Product> GetProductList()
        {
            return new List<Product>();
        }

        public static List<Customer> GetCustomerList()
        {
            return new List<Customer>();
        }
    }
}
