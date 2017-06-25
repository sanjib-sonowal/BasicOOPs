using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class ProjectionOperators
    {
        /// <summary>
        /// This sample uses select to produce a sequence of ints one higher than those in an existing array of ints.
        /// </summary>
        public void Linq6()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne =
                from n in numbers
                select n + 1;

            Console.WriteLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// This sample uses select to produce a sequence of strings representing the text version of a sequence of ints.
        /// </summary>
        public void Linq8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums =
                from n in numbers
                select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// This sample uses select to produce a sequence of the uppercase and lowercase versions of each word in the original array.
        /// </summary>
        public void Linq9()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords =
                from w in words
                select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }
        }

        /// <summary>
        /// This sample uses select to produce a sequence containing text representations of digits and whether their length is even or odd.
        /// </summary>
        public void Linq10()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitOddEvens =
                from n in numbers
                select new { Digit = strings[n], Even = (n % 2 == 0) };

            foreach (var d in digitOddEvens)
            {
                Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
            }
        }

        /// <summary>
        /// This sample uses select to produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
        /// </summary>
        public void Linq11()
        {
            List<Product> products = Repository.GetProductList();

            var productInfos =
                from p in products
                select new { p.Name, Price = p.UnitPrice };

            Console.WriteLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                Console.WriteLine("{0} is in the category {1} and costs {2} per unit.", productInfo.Name, productInfo.Price);
            }
        }

        /// <summary>
        /// This sample uses an indexed Select clause to determine if the value of ints in an array match their position in the array.
        /// </summary>
        public void Linq12()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });

            Console.WriteLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
            }
        }

        /// <summary>
        /// This sample combines select and where to make a simple query that returns the text form of each digit less than 5.
        /// </summary>
        public void Linq13()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNums =
                from n in numbers
                where n < 5
                select digits[n];

            Console.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// This sample uses a compound from clause to make a query that returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
        /// </summary>
        public void Linq14()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { a, b };

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }
        }

        /// <summary>
        /// This sample uses a compound from clause to select all orders where the order total is less than 500.00.
        /// </summary>
        public void Linq15()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var orders =
                from c in customers
                from o in c.Orders
                where o.Total < 500.00M
                select new { c.Id, c.Name, o.Total };

            foreach (var item in orders)
            {
                Console.WriteLine("{0} order Total: {1}", item.Name, item.Total);
            }
        }

        /// <summary>
        /// This sample uses a compound from clause to select all orders where the order was made in 1998 or later.
        /// </summary>
        public void Linq16()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var orders =
                from c in customers
                from o in c.Orders
                where o.OrderDate >= new DateTime(1998, 1, 1)
                select new { c.Id, c.Name, o.OrderDate };

            foreach (var item in orders)
            {
                Console.WriteLine("{0} order made on: {1}", item.Name, item.OrderDate);
            }
        }

        /// <summary>
        /// This sample uses an indexed SelectMany clause to select all orders, while referring to customers by the order in which they are returned from the query.
        /// </summary>
        public void Linq19()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var customerOrders =
                customers.SelectMany(
                    (cust, custIndex) =>
                    cust.Orders.Select(o => "Customer #" + (custIndex + 1) +
                                            " has an order with OrderID " + o.Id));

            //ObjectDumper.Write(customerOrders);
        }
    }
}
