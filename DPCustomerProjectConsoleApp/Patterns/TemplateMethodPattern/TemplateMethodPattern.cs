using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class TemplateMethodPattern
    {
        /*
         * Definition 1 : Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
         * Definition 2 : The template method pattern is a behavioral design pattern that defines the program skeleton of an algorithm in an operation, 
         * deferring some steps to subclasses.[1] It lets one redefine certain steps of an algorithm without changing the algorithm's structure.
         */

        public static void RunProgram()
        {
            Console.WriteLine("TEMPLATE METHOD PATTERN");
            Console.WriteLine("=============================>>>");

            Pizza pizza = new MeatLoafPizza();
            pizza.MakePizza();

            pizza = new VeggiePizza();
            pizza.MakePizza();

            Console.WriteLine("*************************************************\n");
        }
    }
}
