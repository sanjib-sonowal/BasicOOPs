using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class StaticConstructor
    {
        public string abc;
        public string xyz;

        static StaticConstructor()
        {
            Console.WriteLine("I am Static Constructor");
        }

        public StaticConstructor()
        {
            abc = "Hello!";
            xyz = "Sanjib";
        }
    }
}
