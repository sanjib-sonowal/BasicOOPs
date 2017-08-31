using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class DecoratorPattern
    {
        /*
         * Definition 1 : Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
         */
        public static void RunProgram()
        {
            Console.WriteLine("DECORATOR PATTERNS");
            Console.WriteLine("=============================>>>");

            IceCream iceCream = new Chcolate();
            // Add Toppings Fudge
            iceCream = new Fudge(iceCream);
            // Add Toppings Sprinkes
            iceCream = new Sprinkle(iceCream);

            Console.WriteLine(iceCream.Cost());

            Console.WriteLine("*************************************************\n");
        }
    }
}
