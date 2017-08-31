using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class USBAdapter
    {
        USBMouse usbMouse = new USBMouse();

        public void ConnectA()
        {
            usbMouse.ConnectUSBMouse();
            Console.WriteLine("Converting signal to USB");
            Console.WriteLine("Sending new converted signal to Computer");
        }
    }
}
