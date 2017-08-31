using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class AdapterPattern
    {
        /*
         * Definition 1 : Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
         * Definition 2 : The Adapter pattern is a software design pattern (also known as Wrapper, an alternative naming shared with the Decorator 
         * pattern) that allows the interface of an existing class to be used as another interface. It is often used to make 
         * existing classes work with others without modifying their source code.
         */

        public static void RunProgram()
        {
            Console.WriteLine("ADAPTER PATTERN");
            Console.WriteLine("=============================>>>");

            USBAdapter usb = new USBAdapter();
            // ConnectA() is a common Adapter interface method.
            usb.ConnectA();

            Console.WriteLine("Got the signal!");

            Console.WriteLine("*************************************************\n");
        }
    }
}
