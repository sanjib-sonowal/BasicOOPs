using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class MiscellaneousOperators
    {
        /// <summary>
        /// CONCAT : This sample uses Concat to create one sequence that contains each array's values, one after the other.
        /// </summary>
        public void Linq94()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var allNumbers = numbersA.Concat(numbersB);

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Linq95()
        {
            List<Customer> customers = Repository.GetCustomerList();
            List<Product> products = Repository.GetProductList();

            var customerNames =
                from c in customers
                select c.Name;
            var productNames =
                from p in products
                select p.Name;

            var allNames = customerNames.Concat(productNames);

            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// EQUALALL : This sample uses EqualAll to see if two sequences match on all elements in the same order.
        /// </summary>
        public void Linq96()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine("The sequences match: {0}", match);
        }

        /// <summary>
        /// EQUALALL : This sample uses EqualAll to see if two sequences match on all elements in the same order.
        /// </summary>
        public void Linq97()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine("The sequences match: {0}", match);
        }
    }
}
