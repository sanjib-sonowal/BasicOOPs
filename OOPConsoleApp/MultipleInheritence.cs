using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class OperMultipleInheritenceations : IFace1, IFace2, IFace3
    {
        public int Function1(int g, int h)
        {
            return g + h;
        }

        public int Function2(int i, int j)
        {
            return i - j;
        }

        public int Function3(int k, int l)
        {
            return k * l;
        }
    }

    interface IFace1
    {
        int Function1(int a, int b);
    }

    interface IFace2
    {
        int Function2(int c, int d);
    }

    interface IFace3
    {
        int Function3(int e, int f);
    }
}
