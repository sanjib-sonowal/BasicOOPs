using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class IteratorPattern
    {
        /*
         * Definition 1 : Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
         * Definition 2 : The iterator pattern is a design pattern in which an iterator is used to traverse a container and access the container's 
         * elements. The iterator pattern decouples algorithms from containers; in some cases, algorithms are necessarily 
         * container-specific and thus cannot be decoupled.
         */

        public static void RunProgram()
        {
            Console.WriteLine("ITERATOR PATTERNS");
            Console.WriteLine("=============================>>>");

            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            Console.WriteLine("###Facebook User###");
            PrintUser(fbIterator);
            Console.WriteLine();

            Console.WriteLine("###Twitter User###");
            PrintUser(twIterator);

            Console.WriteLine("*************************************************\n");
        }

        public static void PrintUser(IIterator iterate)
        {
            iterate.First();
            while(!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
