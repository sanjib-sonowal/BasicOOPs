using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class RefOutParams
    {
        public static void RefSample(ref int val)
        {
            val += 10;
        }

        public static int OutSample(int val1, int val2, out int val3)
        {
            val1 = 5;
            val2 = 10;
            val3 = val1 + val2;
            return val3;
        }
    }
}
