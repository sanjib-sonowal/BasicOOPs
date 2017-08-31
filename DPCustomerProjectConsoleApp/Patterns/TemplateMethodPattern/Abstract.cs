using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class Pizza
    {
        // Template Method
        public void MakePizza()
        {
            MakeDough();
            AddSauce();
            AddCheese();
            AddToppings();
        }

        public void MakeDough()
        {
            Console.WriteLine("Worked the dough");
        }

        public void AddSauce()
        {
            Console.WriteLine("Adding sauce");
        }

        public void AddCheese()
        {
            Console.WriteLine("Adding cheese");
        }

        public abstract void AddToppings();
    }
}
