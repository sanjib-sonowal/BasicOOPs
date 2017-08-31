using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    // Assume FACADE is a Restraunt name PizzaFacade.
    public class PizzaFacade
    {
        private Rocky rock;
        private Sauce sauce;
        private Cheese cheese;
        private Topping toppings;
        private Oven oven;

        public PizzaFacade(Rocky rock, Sauce sauce, Cheese cheese, Topping toppings)
        {
            this.rock = rock;
            this.sauce = sauce;
            this.cheese = cheese;
            this.toppings = toppings;
        }

        public void MakePizza()
        {
            rock.AddSauce(sauce);
            rock.AddCheese(cheese);
            rock.AddTopping(toppings);
            oven.SetTemperatur(425);
            oven.SetTimer(20);
            oven.Cook(rock);
        }
    }
}
