using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Fudge : IceCreamToppings
    {
        public Fudge(IceCream s) : base(s)
        {}

        public override double Cost()
        {
            return 2.5 + iceCream.Cost();
        }
    }

    public class Sprinkle : IceCreamToppings
    {
        public Sprinkle(IceCream s) : base(s)
        { }

        public override double Cost()
        {
            return 3 + iceCream.Cost();
        }
    }
}
