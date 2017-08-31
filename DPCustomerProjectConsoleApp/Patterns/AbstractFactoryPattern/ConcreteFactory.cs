using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class AsiaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Deer();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    public class AustraliaFactory : ContinentFactory
    {

        public override Herbivore CreateHerbivore()
        {
            return new Sheep();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Tiger();
        }
    }
}
