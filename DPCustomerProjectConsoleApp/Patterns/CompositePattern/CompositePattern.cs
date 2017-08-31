using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class CompositePattern
    {
        /*
         * Definition 1 : Compose objects into tree structures to represent part-whole hierarchies. 
         * Composite lets clients treat individual objects and compositions of objects uniformly.
         * Definition 2 : The composite pattern is a partitioning design pattern. The composite pattern describes a group of objects that is treated 
         * the same way as a single instance of the same type of object. The intent of a composite is to "compose" objects into tree 
         * structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects 
         * and compositions uniformly.
         */

        public static void RunProgram()
        {
            Console.WriteLine("COMPOSITE PATTERN");
            Console.WriteLine("=============================>>>");

            EmployeeComposite sam = new EmployeeComposite("Sam");
            EmployeeLeaf prachi = new EmployeeLeaf("Prachi");
            EmployeeLeaf olga = new EmployeeLeaf("Olga");

            EmployeeComposite mark = new EmployeeComposite("Mark");
            EmployeeComposite christian = new EmployeeComposite("Christian");
            EmployeeLeaf logo = new EmployeeLeaf("Logo");
            EmployeeLeaf pogo = new EmployeeLeaf("Pogo");

            // Clint is the boss of Sam and Mark
            EmployeeComposite clint = new EmployeeComposite("Clint");
            clint.AddEmployee(sam);
            clint.AddEmployee(mark);

            // Sam is the boss of Prachi and Olga
            sam.AddEmployee(prachi);
            sam.AddEmployee(olga);

            // Mark is the boss of Christian
            mark.AddEmployee(christian);

            // Christian is the boss of Logo and Pogo
            christian.AddEmployee(logo);
            christian.AddEmployee(pogo);

            // Print by calling the very top
            clint.PrintSupervisorOf(0);

            Console.WriteLine("*************************************************\n");
        }
    }
}
