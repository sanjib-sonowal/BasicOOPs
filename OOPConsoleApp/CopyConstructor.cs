using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class CopyConstructor
    {
        public string abc;
        public string xyz;

        // Regular Constructor
        public CopyConstructor(string a, string x)
        {
            abc = a;
            xyz = x;
        }

        // Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            abc = obj.abc;
            xyz = obj.xyz;
        }
    }
}
