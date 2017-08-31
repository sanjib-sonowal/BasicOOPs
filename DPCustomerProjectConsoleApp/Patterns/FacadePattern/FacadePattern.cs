using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    /*
     * Definition 1 : Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.
     * Definition 2 : A facade is an object that provides a simplified interface to a larger body of code, such as a class library. 
     * A facade can wrap a poorly designed collection of APIs with a single well-designed API.
     */
    public static class FacadePattern
    {
        // Program is the CLIENT
        public static void RunProgram()
        {
            Console.WriteLine("FACADE PATTERNS");
            Console.WriteLine("=============================>>>");

            Client1();
            Client2();

            Console.WriteLine("*************************************************\n");
        }

        public static void Client1()
        {
            Rocky rock = new Rocky();
            Sauce sauce = new Sauce("Tomato");
            Cheese cheese = new Cheese("Mozarella");
            Topping toppings = new Topping("Mushroom");
            Oven oven = new Oven();

            PizzaFacade pf = new PizzaFacade(rock, sauce, cheese, toppings);
            pf.MakePizza();
        }

        public static void Client2()
        {
            Rocky rock = new Rocky();
            Sauce sauce = new Sauce("Tomato");
            Cheese cheese = new Cheese("Mozarella");
            Topping toppings = new Topping("Chicken");
            Oven oven = new Oven();

            PizzaFacade pf = new PizzaFacade(rock, sauce, cheese, toppings);
            pf.MakePizza();
        }
    }
}
