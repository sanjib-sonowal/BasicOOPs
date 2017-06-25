using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class PartitioningOperators
    {
        /// <summary>
        /// This sample uses Take to get only the first 3 elements of the array.
        /// </summary>
        public void Linq20()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses Take to get the first 3 orders from customers in Washington.
        /// </summary>
        public void Linq21()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var first3WAOrders = (
                from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new { c.Id, c.Name, o.OrderDate })
                .Take(3);

            Console.WriteLine("First 3 orders in WA:");
            foreach (var order in first3WAOrders)
            {
                //ObjectDumper.Write(order);
            }
        }

        /// <summary>
        /// This sample uses Skip to get all but the first 4 elements of the array.
        /// </summary>
        public void Linq22()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers.Skip(4);

            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses Take to get all but the first 2 orders from customers in Washington.
        /// </summary>
        public void Linq23()
        {

            List<Customer> customers = Repository.GetCustomerList();
            var waOrders =
                from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new { c.Id, c.Name, o.OrderDate };

            var allButFirst2Orders = waOrders.Skip(2);

            Console.WriteLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
            {
                //ObjectDumper.Write(order);
            }
        }

        /// <summary>
        /// This sample uses TakeWhile to return elements starting from the beginning of the array until a number is hit that is not less than.
        /// </summary>
        public void Linq24()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses TakeWhile to return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
        /// </summary>
        public void Linq25()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

            Console.WriteLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses SkipWhile to get the elements of the array starting from the first element divisible by 3.
        /// </summary>
        public void Linq26()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses SkipWhile to get the elements of the array starting from the first element less than its position.
        /// </summary>
        public void Linq27()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
