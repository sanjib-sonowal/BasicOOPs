using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class NullObjectPattern : IWeapon
    {
        /*
            A null object is an object with defined nutral ("null") behaviour. 
            NullObject Patten describes the uses of such objects and their behaviours.
        */

        public void Use()
        {
            Console.WriteLine("Null Object Encountered");
        }
    }
}
