using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class ValueAndReferenceTypes
    {
        public static void ValueTypeTest()
        {
            int i = 10, j = 11;
            Console.WriteLine("i = {0} and j = {1}", i, j);
        }

        public static void ReferenceTypeTest()
        {
            Entities.Employee emp1 = new Entities.Employee();
            emp1.Name = "ABC";

            Entities.Employee emp2 = emp1;
            emp2.Name = "XYZ";

            Console.WriteLine("Emp1 Name is {0} Emp2 Name is {1}", emp1.Name, emp2.Name);
        }
    }
}
