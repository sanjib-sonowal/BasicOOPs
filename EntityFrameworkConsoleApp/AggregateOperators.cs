﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class AggregateOperators
    {
        /// <summary>
        /// COUNT : This sample uses Count to get the number of unique factors of 300.
        /// </summary>
        public void Linq73()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
        }

        /// <summary>
        /// COUNT CONDITIONAL : This sample uses Count to get the number of odd ints in the array.
        /// </summary>
        public void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }

        /// <summary>
        /// COUNT NESTED : This sample uses Count to return a list of customers and how many orders each has.
        /// </summary>
        public void Linq76()
        {
            List<Customer> customers = Repository.GetCustomerList();

            var orderCounts =
                from c in customers
                select new { c.Id, OrderCount = c.Orders.Count() };

            //ObjectDumper.Write(orderCounts);
        }

        /// <summary>
        /// COUNT GROUPED : This sample uses Count to return a list of categories and how many products each has.
        /// </summary>
        public void Linq77()
        {
            List<Product> products = Repository.GetProductList();

            var categoryCounts =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, ProductCount = g.Count() };

            //ObjectDumper.Write(categoryCounts);
        }

        /// <summary>
        /// SUM : This sample uses Sum to get the total of the numbers in an array.
        /// </summary>
        public void Linq78()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double numSum = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
        }

        /// <summary>
        /// SUM PROJECTION : This sample uses Sum to get the total number of characters of all words in the array.
        /// </summary>
        public void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(w => w.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

        /// <summary>
        /// SUM GROUPED : This sample uses Sum to get the total units in stock for each product category.
        /// </summary>
        public void Linq80()
        {
            List<Product> products = Repository.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitInStock) };

            //ObjectDumper.Write(categories);
        }

        /// <summary>
        /// MIN : This sample uses Min to get the lowest number in an array.
        /// </summary>
        public void Linq81()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int minNum = numbers.Min();

            Console.WriteLine("The minimum number is {0}.", minNum);
        }

        /// <summary>
        /// MIN PROJECTION : This sample uses Min to get the length of the shortest word in an array.
        /// </summary>
        public void Linq82()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }

        /// <summary>
        /// MIN GROUPED : This sample uses Min to get the cheapest price among each category's products.
        /// </summary>
        public void Linq83()
        {
            List<Product> products = Repository.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) };

            //ObjectDumper.Write(categories);
        }

        /// <summary>
        /// MIN ELEMENTS : This sample uses Min to get the products with the cheapest price in each category.
        /// </summary>
        public void Linq84()
        {
            List<Product> products = Repository.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                let minPrice = g.Min(p => p.UnitPrice)
                select new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == minPrice) };

            //ObjectDumper.Write(categories, 1);
        }

        /// <summary>
        /// MAX : This sample uses Max to get the highest number in an array.
        /// </summary>
        public void Linq85()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int maxNum = numbers.Max();

            Console.WriteLine("The maximum number is {0}.", maxNum);
        }

        /// <summary>
        /// MAX PROJECTION : This sample uses Max to get the length of the longest word in an array.
        /// </summary>
        public void Linq86()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int longestLength = words.Max(w => w.Length);

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }

        /// <summary>
        /// MAX GROUPED : This sample uses Max to get the most expensive price among each category's products.
        /// </summary>
        public void Linq87()
        {
            List<Product> products = Repository.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) };

            //ObjectDumper.Write(categories);
        }

        /// <summary>
        /// MAX ELEMENTS : This sample uses Max to get the products with the most expensive price in each category.
        /// </summary>
        public void Linq88()
        {
            List<Product> products = Repository.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                let maxPrice = g.Max(p => p.UnitPrice)
                select new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == maxPrice) };

            //ObjectDumper.Write(categories, 1);
        }

        /// <summary>
        /// AVERAGE : This sample uses Average to get the average of all numbers in an array.
        /// </summary>
        public void Linq89()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double averageNum = numbers.Average();

            Console.WriteLine("The average number is {0}.", averageNum);
        }

        /// <summary>
        /// AVERAGE PROJECTION : This sample uses Average to get the average length of the words in the array.
        /// </summary>
        public void Linq90()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine("The average word length is {0} characters.", averageLength);
        }

        /// <summary>
        /// AVERAGE GROUPED : This sample uses Average to get the average price of each category's products.
        /// </summary>
        public void Linq91()
        {
            List<Product> products = Repository.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) };

            //ObjectDumper.Write(categories);
        }

        /// <summary>
        /// AGGREGATE : This sample uses Aggregate to create a running product on the array that calculates the total product of all elements.
        /// </summary>
        public void Linq92()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", product);
        }

        /// <summary>
        /// AGGREGATE SEED :This sample uses Aggregate to create a running account balance that subtracts each withdrawal from the initial balance of 100, as long as the balance never drops below 0.
        /// </summary>
        public void Linq93()
        {
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine("Ending balance: {0}", endBalance);
        }
    }
}
