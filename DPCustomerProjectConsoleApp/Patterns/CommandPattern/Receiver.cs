using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights are on!");
        }

        public void Off()
        {
            Console.WriteLine("Lights are off!");
        }
    }

    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("AC is on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("AC is off!");
        }

        public void IncreaseTemp()
        {
            Console.WriteLine("AC temperature increased!");
        }

        public void DecreaseTemp()
        {
            Console.WriteLine("AC temperature decreased!");
        }
    }
}
