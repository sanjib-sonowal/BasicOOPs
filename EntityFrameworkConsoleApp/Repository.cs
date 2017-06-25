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
            return new List<Product>(){
                new Product(){ Id = 1, Name = "Nike Football Size 5", UnitInStock = 1000, UnitPrice = 3000 },
                new Product(){ Id = 2, Name = "Nike Football Size 4", UnitInStock = 40, UnitPrice = 1000 },
                new Product(){ Id = 3, Name = "Nike Football Size 3", UnitInStock = 80, UnitPrice = 750 },
                new Product(){ Id = 4, Name = "Nike Jersey Size M", UnitInStock = 40, UnitPrice = 1500 },
                new Product(){ Id = 5, Name = "Nike Jersey Size L", UnitInStock = 0, UnitPrice = 1500 },
                new Product(){ Id = 6, Name = "Adidas Studs Size 9", UnitInStock = 200, UnitPrice = 4000 },
                new Product(){ Id = 7, Name = "Adidas Studs Size 10", UnitInStock = 250, UnitPrice = 4000 },
                new Product(){ Id = 8, Name = "Puma Evopower Size 9", UnitInStock = 400, UnitPrice = 3500 },
                new Product(){ Id = 9, Name = "Puma Evopower Size 10", UnitInStock = 400, UnitPrice = 3200 },
                new Product(){ Id = 10, Name = "Under Armour Football Shorts Size M", UnitInStock = 900, UnitPrice = 800 }
            };
        }

        public static List<Customer> GetCustomerList()
        {
            return new List<Customer>();
        }
    }
}
