using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class SingletonPattern
    {
        /*
         * Definition 1 : Ensure a class has only one instance and provide a global point of access to it.
         * Definition 2 : The singleton pattern is a software design pattern that restricts the instantiation of a class to one object. 
         * This is useful when exactly one object is needed to coordinate actions across the system. The concept is sometimes 
         * generalized to systems that operate more efficiently when only one object exists, or that restrict the instantiation 
         * to a certain number of objects.
         */

        public static void RunProgram()
        {
            Console.WriteLine("SINGLETON PATTERN");
            Console.WriteLine("=============================>>>");

            Logger log = Logger.GetInstance();
            log.WriteToFile("Write to file!");

            Logger log2 = Logger.GetInstance();
            log.WriteToFile("Test if using the same logger instance!");

            Console.WriteLine("*************************************************\n");
        }
    }
}
