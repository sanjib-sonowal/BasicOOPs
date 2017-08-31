using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class DictonaryAndHashtable
    {
        public void HashtableTest()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Batman");
            ht.Add("102", "Justice League");
            ht.Add(103, "Captain America");
            ht.Add("104", "Avengers");
            
            Console.WriteLine(ht[101]);
            Console.WriteLine(ht["102"]);
            Console.WriteLine(ht[103]);
            Console.WriteLine(ht["104"]);
        }

        public void DictionaryTest()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(101, "Batman");
            dict.Add(102, "Justice League");
            dict.Add(103, "Captain America");
            dict.Add(104, "Avengers");

            Console.WriteLine(dict[101]);
            Console.WriteLine(dict[102]);
            Console.WriteLine(dict[103]);
            Console.WriteLine(dict[104]);
        }
    }
}
