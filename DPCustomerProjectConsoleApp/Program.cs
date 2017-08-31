using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns;
using IQs;

namespace DPCustomerProjectConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDBEntities dbContext = new CustomerDBEntities();

            #region BASIC PATTERNS

            #region LAZY & EAGER LOADING PATTERNS
            Console.WriteLine("LAZY & EAGER LOADING PATTERNS");
            Console.WriteLine("=============================>>>");
            foreach (Customer cust in dbContext.Customers.ToList())
            {
                Console.WriteLine(cust.CustomerName + " from " + cust.Address + " bill amount is " + cust.BillAmount);
                foreach (Order order in cust.Orders)
                {
                    Console.WriteLine("Order Number : " + order.OrderNumber);
                }
                Console.WriteLine("----------------------------------------------------------------------");
            }
            Console.WriteLine("*************************************************\n");
            #endregion

            #endregion

            #region BASIC IQs

            double celcius = 32, fehrenheit = 90.5;
            Console.WriteLine("{0} Celcius = {1} Fehrenheit", celcius, Converter.ToFahrenheit(celcius));
            Console.WriteLine("{0} Fehrenheit = {1} Celcius", fehrenheit, Converter.ToFahrenheit(fehrenheit));

            #endregion

            #region CREATIONAL PATTERNS

            #region ABSTRACT FACTORY PATTERN
            AbstractFactoryPatternClient.RunProgram();
            #endregion

            #region FACTORY METHOD PATTERN
            FactoryMethodPattern.RunProgram();
            #endregion

            #region PROTOTYPE PATTERN
            PrototypePattern.RunProgram();
            #endregion

            #region SINGLETON PATTERN
            SingletonPattern.RunProgram();
            #endregion

            #endregion

            #region STRUCTURAL PATTERNS

            #region ADAPTER PATTERN
            AdapterPattern.RunProgram();
            #endregion

            #region COMPOSITE PATTERN
            CompositePattern.RunProgram();
            #endregion

            #region DECORATOR PATTERN
            DecoratorPattern.RunProgram();
            #endregion

            #region FACADE PATTERN
            //FacadePattern.RunProgram();
            #endregion

            #endregion

            #region BEHAVIOURIAL PATTERNS

            #region COMMAND PATTERN
            CommandPattern.RunProgram();
            #endregion

            #region ITERATOR PATTERN
            IteratorPattern.RunProgram();
            #endregion

            #region OBSERVER PATTERN
            ObserverPattern.RunProgram();
            #endregion

            #region STRATEGY PATTERNS
            StrategyPattern.RunProgram();
            Console.WriteLine("*************************************************\n");
            #endregion

            #region MEMENTO PATTERN
            MementoPattern.RunProgram();
            #endregion

            #region TEMPLATE METHOD PATTERN
            TemplateMethodPattern.RunProgram();
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
