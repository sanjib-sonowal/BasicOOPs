using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* INHERITENCE TEST -- START  */

            Console.WriteLine("INHERITENCE TEST");
            Console.WriteLine("=======================>>>");
            Child C1 = new Child();
            C1.Write();
            //Type caste C1 to be of type Parent and call Write () method
            ((Parent)C1).Write();
            Console.WriteLine("*************************************************\n");

            /* INHERITENCE TEST -- END  */

            /* POLYMORPHISM TEST -- START  */

            Console.WriteLine("POLYMORPHISM TEST");
            Console.WriteLine("=======================>>>");
            Console.WriteLine("FUNCTION OVERLOADING -> Static Binding");
            Print p1 = new Print();
            p1.display("Sanjib Sonowal");
            p1.display("Olga", 19);

            Shape ob = new Shape();
            ob.Area(2.0f);
            ob.Area(20.0f, 30.0f);
            ob.Area(2.0f, 3.0f, 4.0f);
            Console.WriteLine("*************************************************");
            Console.WriteLine("FUNCTION OVERRDING -> Dynamic Binding");
            DerivedClass objDC = new DerivedClass();
            objDC.Function1();
            BaseClass objBC = (BaseClass)objDC;
            objDC.Function1();
            Console.WriteLine("\n*************************************************\n");

            /* POLYMORPHISM TEST -- END  */

            /* STOPS AUTOMATICALLY EXIT */
            Console.ReadLine();
        }
    }
}
