using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Rocky
    {
        public void AddSauce(Sauce s)
        {
            // TODO
        }

        public void AddTopping(Topping t)
        {
            // TODO
        }

        public void AddCheese(Cheese c)
        {
            // TODO
        }
    }

    public class Sauce
    {
        private string p;

        public Sauce(string p)
        {
            this.p = p;
        }
    }

    public class Topping
    {
        private string p;

        public Topping(string p)
        {
            this.p = p;
        }
    }

    public class Cheese
    {
        private string p;

        public Cheese(string p)
        {
            this.p = p;
        }
    }

    public class Oven
    {
        public void SetTemperatur(int temp)
        {
            // TODO
        }

        public void SetTimer(double min)
        {
            // TODO
        }

        public void Cook(Rocky r)
        {
            // TODO
        }
    }
}
