using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region RESTRICTION OPERATORS

            RestrictionOperators roObj = new RestrictionOperators();
            //roObj.Linq1();

            roObj.Linq2();

            #endregion

            /* STOP CONSOLE FROM TERMINATING */
            Console.ReadLine();
        }
    }
}
