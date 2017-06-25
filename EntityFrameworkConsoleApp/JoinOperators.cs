using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class JoinOperators
    {
        /// <summary>
        /// CROSS JOIN: This sample shows how to efficiently join elements of two sequences based on equality between key expressions over the two.
        /// </summary>
        public void Linq102()
        {

            string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };

            List<Product> products = Repository.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category
                select new { Category = c, p.Name };

            foreach (var v in q)
            {
                Console.WriteLine(v.Name + ": " + v.Category);
            }
        }

        /// <summary>
        /// GROUP JOIN : Using a group join you can get all the products that match a given category bundled as a sequence.
        /// </summary>
        public void Linq103()
        {
            string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };

            List<Product> products = Repository.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category into ps
                select new { Category = c, Products = ps };

            foreach (var v in q)
            {
                Console.WriteLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    Console.WriteLine("   " + p.Name);
                }
            }
        }

        /// <summary>
        /// CROSS JOIN With GROUP JOIN : The group join operator is more general than join, as this slightly more verbose version of the cross join sample shows.
        /// </summary>
        public void Linq104()
        {
            string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };

            List<Product> products = Repository.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category into ps
                from p in ps
                select new { Category = c, p.Name };

            foreach (var v in q)
            {
                Console.WriteLine(v.Name + ": " + v.Category);
            }
        }

        /// <summary>
        /// LEFT OUTER JOIN : A so-called outer join can be expressed with a group join. A left outer joinis like a cross join, except that all the left hand side elements get included at least once, even if they don't match any right hand side elements. Note how Vegetablesshows up in the output even though it has no matching products.
        /// </summary>
        public void Linq105()
        {
            string[] categories = new string[]{
            "Beverages",
            "Condiments",
            "Vegetables",
            "Dairy Products",
            "Seafood" };

            List<Product> products = Repository.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category into ps
                from p in ps.DefaultIfEmpty()
                select new { Category = c, ProductName = p == null ? "(No products)" : p.Name };

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
        }
    }
}
