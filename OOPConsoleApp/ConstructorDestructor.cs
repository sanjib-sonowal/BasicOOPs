using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class ConstructorDestructor
    {

    }

    public class Math
    {
        private int x;
        private int y;

        // CONSTRUCTOR
        public Math(int i, int j)
        {
            x = i;
            y = j;
        }

        public void add()
        {
            Console.WriteLine(x + "+" + y);
        }
        
        /// DESTRUCTOR
        ~Math()
        {
            
        }
    }
}
