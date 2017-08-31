using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herb)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herb.GetType().Name);
        }
    }

    public class Tiger : Carnivore
    {
        public override void Eat(Herbivore herb)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herb.GetType().Name);
        }
    }

    public class Deer : Herbivore
    {}

    public class Sheep : Herbivore
    {}
}
