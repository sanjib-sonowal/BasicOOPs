﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class SetOperators
    {
        /// <summary>
        /// This sample uses Distinct to remove duplicate elements in a sequence of factors of 300.
        /// </summary>
        public void Linq46()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            var uniqueFactors = factorsOf300.Distinct();

            Console.WriteLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                Console.WriteLine(f);
            }
        }

        /// <summary>
        /// This sample uses Distinct to find the unique Category names.
        /// </summary>
        public void Linq47()
        {
            List<Product> products = Repository.GetProductList();

            var categoryNames = (
                from p in products
                select p.Category)
                .Distinct();

            Console.WriteLine("Category names:");
            foreach (var n in categoryNames)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses Union to create one sequence that contains the unique values from both arrays.
        /// </summary>
        public void Linq48()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses Union to create one sequence that contains the unique first letter from both product and customer names.
        /// </summary>
        public void Linq49()
        {
            List<Product> products = Repository.GetProductList();
            List<Customer> customers = Repository.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.Name[0];
            var customerFirstChars =
                from c in customers
                select c.Name[0];

            var uniqueFirstChars = productFirstChars.Union(customerFirstChars);

            Console.WriteLine("Unique first letters from Product names and Customer names:");
            foreach (var ch in uniqueFirstChars)
            {
                Console.WriteLine(ch);
            }
        }

        /// <summary>
        /// This sample uses Intersect to create one sequence that contains the common values shared by both arrays.
        /// </summary>
        public void Linq50()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var commonNumbers = numbersA.Intersect(numbersB);

            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses Intersect to create one sequence that contains the common first letter from both product and customer names.
        /// </summary>
        public void Linq51()
        {
            List<Product> products = Repository.GetProductList();
            List<Customer> customers = Repository.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.Name[0];
            var customerFirstChars =
                from c in customers
                select c.Name[0];

            var commonFirstChars = productFirstChars.Intersect(customerFirstChars);

            Console.WriteLine("Common first letters from Product names and Customer names:");
            foreach (var ch in commonFirstChars)
            {
                Console.WriteLine(ch);
            }
        }

        /// <summary>
        /// This sample uses Except to create a sequence that contains the values from numbersAthat are not also in numbersB.
        /// </summary>
        public void Linq52()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);

            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// This sample uses Except to create one sequence that contains the first letters of product names that are not also first letters of customer names.
        /// </summary>
        public void Linq53()
        {
            List<Product> products = Repository.GetProductList();
            List<Customer> customers = Repository.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.Name[0];
            var customerFirstChars =
                from c in customers
                select c.Name[0];

            var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

            Console.WriteLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
