using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class AbstractFactoryPatternClient
    {
        /*
         * Def 1 : Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
         * Def 2 : The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.
         * More Info : https://en.wikipedia.org/wiki/Abstract_factory_pattern
         */

        public static void RunProgram()
        {
            Console.WriteLine("ABSTRACT FACTORY PATTERN");
            Console.WriteLine("=============================>>>");

            ContinentFactory asiaFactory = new AsiaFactory();
            AnimalWorld world = new AnimalWorld(asiaFactory);
            world.RunFoodChain();

            ContinentFactory ausFactory = new AustraliaFactory();
            world = new AnimalWorld(ausFactory);
            world.RunFoodChain();

            Console.WriteLine("*************************************************\n");
        }
    }
}
