using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class USBMouse
    {
        public void ConnectUSBMouse()
        {
            Console.WriteLine("Sending signal to Adapter from USB mouse");
        }
    }

    public class PS2Mouse
    {
        public void ConnectPS2Mouse()
        {
            Console.WriteLine("Sending signal to Adapter from PS2 mouse");
        }
    }
}
