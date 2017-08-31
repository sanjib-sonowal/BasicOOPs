using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class Herbivore
    {}

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herb);
    }
}
