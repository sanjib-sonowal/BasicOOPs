using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions()
        {
            Console.WriteLine("My Custom Exception...");
        }
    }
}
