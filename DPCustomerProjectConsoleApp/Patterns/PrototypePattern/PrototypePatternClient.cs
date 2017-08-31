using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns
{
    public static class PrototypePattern
    {
        /*
         * It is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects. 
         * This pattern is used to:
         *  1. Avoid subclasses of an object creator in the client application, like the factory method pattern does.
         *  2. Avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) when it is prohibitively expensive for a given application.
         */
        
        // Prototype Pattern : Client
        public static void RunProgram()
        {
            Console.WriteLine("PROTOTYPE PATTERN");
            Console.WriteLine("=============================>>>");

            XBoxGame xg1 = new Halo("Halo 4") { ProductKey = "00000-00000-00000-00000" }; // Original copy of Halo
            XBoxGame xg2 = new FinalFantasy("Final Fantasy") { ProductKey = "00000-00000-00000-00000" }; // Original copy of Final Fantasy
            XBoxGame gameCopy;

            for(int i=0; i<2; i++)  
            {
                Thread.Sleep(2000);
                gameCopy = xg1.Clone();
                gameCopy.ProductKey = XBoxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title : {0}, Product Key : {1}", gameCopy.Title, gameCopy.ProductKey);

                Thread.Sleep(2000);
                gameCopy = xg2.Clone();
                gameCopy.ProductKey = XBoxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title : {0}, Product Key : {1}", gameCopy.Title, gameCopy.ProductKey);
            }

            Console.WriteLine("*************************************************\n");
        }
    }
}
