using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class LightOn : ICommand
    {
        Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }

    public class LightOff : ICommand
    {
        Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }

    public class ACOn : ICommand
    {
        AirConditioner ac;

        public ACOn(AirConditioner ac)
        {
            this.ac = ac;
        }

        public void Execute()
        {
            ac.TurnOn();
            ac.IncreaseTemp();
        }
    }

    public class ACOff : ICommand
    {
        AirConditioner ac;

        public ACOff(AirConditioner ac)
        {
            this.ac = ac;
        }

        public void Execute()
        {
            ac.DecreaseTemp();
            ac.TurnOff();
        }
    }
}
