using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class IceCreamToppings : IceCream
    {
        protected IceCream iceCream { get; set; }

        protected IceCreamToppings(IceCream s)
        {
            iceCream = s;
        }
    }
}
