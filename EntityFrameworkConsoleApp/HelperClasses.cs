using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public static class HelperClasses
    {
        public static IEnumerable Combine(this IEnumerable first, IEnumerable second, /*Func func*/)
        {
            //using (IEnumerator e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            //{
            //    while (e1.MoveNext() && e2.MoveNext())
            //    {
            //        yield return func(e1.Current, e2.Current);
            //    }
            //}

            // TEMP
            return null;
        }
    }
}
