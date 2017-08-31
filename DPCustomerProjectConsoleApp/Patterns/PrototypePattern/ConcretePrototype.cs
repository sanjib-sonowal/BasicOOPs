using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    // Prototype Pattern : ConcretePrototype1 
    public class Halo : XBoxGame
    {
        public Halo(string title)
        {
            Title = title;
        }

        public override XBoxGame Clone()
        {
            // MemberwiseClone : Creates a shallow copy of the current object.
            return (Halo)this.MemberwiseClone();
        }
    }

    // Prototype Pattern : ConcretePrototype1
    public class FinalFantasy : XBoxGame
    {
        public FinalFantasy(string title)
        {
            Title = title;
        }

        public override XBoxGame Clone()
        {
            return (FinalFantasy)this.MemberwiseClone();
        }
    }
}
