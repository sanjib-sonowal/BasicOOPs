using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Sword");
        }
    }

    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Axe");
        }
    }

    public class Club : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Club");
        }
    }
}
