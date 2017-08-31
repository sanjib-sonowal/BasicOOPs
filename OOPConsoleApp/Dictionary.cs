using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class Dictionary
    {
        public static void LoopDictionary()
        {
            Dictionary<int, string> towns = new Dictionary<int, string>();
            towns.Add(1, "Duliajan");
            towns.Add(2, "Digboi");
            towns.Add(3, "Dibrugarh");

            foreach (KeyValuePair<int, string> town in towns)
            {
                Console.WriteLine("Key {0} is for town {1}", town.Key, towns[town.Key]);
            }

            foreach(string town in towns.Values)
            {
                Console.Write(town + ", ");
            }
        }
        
    }
}
