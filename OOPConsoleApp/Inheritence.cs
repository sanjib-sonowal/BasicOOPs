using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class Inheritence
    {
        
    }

    public class Parent
    {
        public void Write()
        {
            Console.WriteLine("Parent Class write method");
        }
    }

    public class Child : Parent
    {
        public new void Write()
        {
            Console.WriteLine("Child Class write method");
        }
    }
}
