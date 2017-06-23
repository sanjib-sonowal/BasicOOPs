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

            /* MULTIPLE INHERITENCE USING INTERFACE -- START  */

            Console.WriteLine("POLYMORPHISM TEST");
            Console.WriteLine("=======================>>>");
            Console.WriteLine("Multiple inheritance using interface\n ");
            OperMultipleInheritenceations obj = new OperMultipleInheritenceations();
            Console.WriteLine("Result1: " + obj.Function1(20, 10));
            Console.WriteLine("Result2: " + obj.Function2(100, 50));
            Console.WriteLine("Result3: " + obj.Function3(30, 3));
            Console.WriteLine("\n*************************************************\n");

            /* MULTIPLE INHERITENCE USING INTERFACE -- END  */

            /* REF & OUT -- START  */

            Console.WriteLine("REF TEST");
            Console.WriteLine("=======================>>>");
            int refVal; // variable need to be initialized
            refVal = 3;
            RefOutParams.RefSample(ref refVal);
            Console.WriteLine(refVal);
            Console.WriteLine("OUT TEST");
            Console.WriteLine("=======================>>>");
            int value;
            RefOutParams.OutSample(5, 5, out value);
            Console.WriteLine("\n*************************************************\n");

            /* REF & OUT -- END  */

            /* STOPS AUTOMATICALLY EXIT */
            Console.ReadLine();
        }
    }
}
