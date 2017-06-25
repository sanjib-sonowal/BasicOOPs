using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class Quantifiers
    {
        /// <summary>
        /// ANY : This sample uses Any to determine if any of the words in the array contain the substring 'ei'.
        /// </summary>
        public void Linq67()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);
        }

        /// <summary>
        /// ANY GROUPED : This sample uses Any to return a grouped a list of products only for categories that have at least one product that is out of stock.
        /// </summary>
        public void Linq69()
        {
            List<Product> products = Repository.GetProductList();
            var productGroups =
                from p in products
                group p by p.Category into g
                where g.Any(p => p.UnitInStock == 0)
                select new { Category = g.Key, Products = g };

            //ObjectDumper.Write(productGroups, 1);
        }

        /// <summary>
        /// ALL : This sample uses All to determine whether an array contains only odd numbers.
        /// </summary>
        public void Linq70()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }

        /// <summary>
        /// ALL GROUPED : This sample uses All to return a grouped a list of products only for categories that have all of their products in stock.
        /// </summary>
        public void Linq72()
        {
            List<Product> products = Repository.GetProductList();

            var productGroups =
                from p in products
                group p by p.Category into g
                where g.All(p => p.UnitInStock > 0)
                select new { Category = g.Key, Products = g };

            //ObjectDumper.Write(productGroups, 1);
        }



    }
}
