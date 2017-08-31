using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class VeggiePizza : Pizza
    {
        public override void AddToppings()
        {
            Console.WriteLine("Adding tomato, green pepper, mushroom etc...");
        }
    }

    public class MeatLoafPizza : Pizza
    {
        public override void AddToppings()
        {
            Console.WriteLine("Adding bacon, chicken etc...");
        }
    }
}
