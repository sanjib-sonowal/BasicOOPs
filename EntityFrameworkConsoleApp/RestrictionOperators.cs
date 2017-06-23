using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class RestrictionOperators
    {
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums =
                from n in numbers
                where n < 5
                select n;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        public void Linq2()
        {
            List<Product> products = Repository.GetProductList();

            var soldOutProducts =
                from p in products
                where p.UnitInStock == 0
                select p;

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine("{0} is sold out!", product.Name);
            }
        }

        public void Linq3()
        {
            List<Product> products = Repository.GetProductList();

            var expensiveInStockProducts =
                from p in products
                where p.UnitInStock > 0 && p.UnitPrice > 3.00M
                select p;

            Console.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine("{0} is in stock and costs more than 3.00.", product.Name);
            }
        }

        public void Linq4()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var waCustomers =
                from c in customers
                where c.Region == "WA"
                select c;

            Console.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                Console.WriteLine("Customer {0}: {1}", customer.Id, customer.Name);
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("  Order {0}: {1}", order.Id, order.OrderDate);
                }
            }
        }

        public void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
        }
    }
}
