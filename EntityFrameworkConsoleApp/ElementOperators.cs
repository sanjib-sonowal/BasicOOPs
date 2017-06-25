using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class ElementOperators
    {
        /// <summary>
        /// This sample uses First to return the first matching element as a Product, instead of as a sequence containing a Product.
        /// </summary>
        public void Linq58()
        {
            List<Product> products = Repository.GetProductList();

            Product product12 = (
                from p in products
                where p.Id == 7
                select p)
                .First();

            //ObjectDumper.Write(product12);
        }

        /// <summary>
        /// This sample uses First to find the first element in the array that starts with 'o'.
        /// </summary>
        public void Linq59()
        {
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string startsWithO = strings.First(s => s[0] == 'o');

            Console.WriteLine("A string starting with 'o': {0}", startsWithO);
        }

        /// <summary>
        /// This sample uses FirstOrDefault to try to return the first element of the sequence, unless there are no elements, in which case the default value for that type is returned.
        /// </summary>
        public void Linq61()
        {
            int[] numbers = { };

            int firstNumOrDefault = numbers.FirstOrDefault();

            Console.WriteLine(firstNumOrDefault);
        }

        /// <summary>
        /// This sample uses FirstOrDefault to return the first product whose ProductID is 789 as a single Product object, unless there is no match, in which case null is returned.
        /// </summary>
        public void Linq62()
        {
            List<Product> products = Repository.GetProductList();

            Product product7 = products.FirstOrDefault(p => p.Id == 7);

            Console.WriteLine("Product 7 exists: {0}", product7 != null);
        }

        /// <summary>
        /// This sample uses ElementAt to retrieve the second number greater than 5 from an array.
        /// </summary>
        public void Linq64()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int fourthLowNum = (
                from n in numbers
                where n > 5
                select n)
                .ElementAt(1);  // second number is index 1 because sequences use 0-based indexing 

            Console.WriteLine("Second number > 5: {0}", fourthLowNum);
        }
    }
}
