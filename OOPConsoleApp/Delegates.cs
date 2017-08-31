using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public delegate void MathDelegate(int a, int b);

    public class Delegates
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add : " + (a + b));
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("Substract : " + (a - b));
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiply : " + (a * b));
        }

        public void Div(int a, int b)
        {
            Console.WriteLine("Divide : " + (a / b));
        }

        public void Mod(int a, int b)
        {
            Console.WriteLine("Modulus : " + (a % b));
        }
    }
}
