using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace CustomerFactory
{
    // Design Pattern : Simple Factory Pattern
    public static class Factory
    {
        private static Dictionary<string, CustomerBase> cutomers = new Dictionary<string, CustomerBase>();

        // Design Pattern : Eager Loading (Opposite of Lazy Loading design pattern).
        // Loading info before whether or not the cient demanded.
        //static Factory()
        //{
        //    Factory.cutomers.Add("Customer", new Customer());
        //    Factory.cutomers.Add("Lead", new Lead());
        //}

        public static CustomerBase Create(string custType)
        {
            // Design Pattern : Lazy Loading. Only on demand loading while calling Create.
            if(Factory.cutomers.Count == 0)
            {
                Factory.cutomers.Add("Customer", new Customer());
                Factory.cutomers.Add("Lead", new Lead());
            }

            // Design Pattern : RIP Pattern (Replace IF with POLYMORPHISM)
            return Factory.cutomers[custType];
        }
    }
}
