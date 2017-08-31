using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    // Generic Method
    public class GenericType1
    {
        public static bool IsEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    // Generic Class
    public class GenericType2<T>
    {
        public static bool IsEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
