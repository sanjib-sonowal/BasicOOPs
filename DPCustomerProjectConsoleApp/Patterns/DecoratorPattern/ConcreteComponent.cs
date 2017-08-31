using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Chcolate : IceCream
    {
        public override double Cost()
        {
            return 15;
        }
    }

    public class Vanilla : IceCream
    {
        public override double Cost()
        {
            return 10;
        }
    }
}
