using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class GroupingOperators
    {
        /// <summary>
        /// This sample uses group by to partition a list of numbers by their remainder when divided by 5.
        /// </summary>
        public void Linq40()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups =
                from n in numbers
                group n by n % 5 into g
                select new { Remainder = g.Key, Numbers = g };

            foreach (var g in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }

        /// <summary>
        /// GroupBy : This sample uses group by to partition a list of products by category.
        /// </summary>
        public void Linq42()
        {
            List<Product> products = Repository.GetProductList();

            var orderGroups =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, Products = g };

            //ObjectDumper.Write(orderGroups, 1);
        }

        /// <summary>
        /// Nested GroupBy : This sample uses group by to partition a list of each customer's orders, first by year, and then by month.
        /// </summary>
        public void Linq43()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var customerOrderGroups =
                from c in customers
                select
                    new
                    {
                        c.Name,
                        YearGroups =
                            from o in c.Orders
                            group o by o.OrderDate.Year into yg
                            select
                                new
                                {
                                    Year = yg.Key,
                                    MonthGroups =
                                        from o in yg
                                        group o by o.OrderDate.Month into mg
                                        select new { Month = mg.Key, Orders = mg }
                                }
                    };

            //ObjectDumper.Write(customerOrderGroups, 3);
        }

        /// <summary>
        /// GroupBy - Comparer : This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other.
        /// </summary>
        public void Linq44()
        {
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());

            //ObjectDumper.Write(orderGroups, 1);
        }

        /// <summary>
        /// GroupBy - Comparer, Mapped : This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other, and then converts the results to uppercase.
        /// </summary>
        public void Linq45()
        {
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            var orderGroups = anagrams.GroupBy(
                        w => w.Trim(),
                        a => a.ToUpper(),
                        new AnagramEqualityComparer()
                        );

            //ObjectDumper.Write(orderGroups, 1);
        }

        #region Helper Methods

        public class AnagramEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return getCanonicalString(x) == getCanonicalString(y);
            }

            public int GetHashCode(string obj)
            {
                return getCanonicalString(obj).GetHashCode();
            }

            private string getCanonicalString(string word)
            {
                char[] wordChars = word.ToCharArray();
                Array.Sort<char>(wordChars);
                return new string(wordChars);
            }
        }

        #endregion
    }
}
