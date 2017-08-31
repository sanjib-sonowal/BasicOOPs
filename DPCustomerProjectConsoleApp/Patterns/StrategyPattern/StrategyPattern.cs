using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class StrategyPattern
    {
        /*
         * Definition 1 : Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
         * Definition 2 : Strategy Patten is a form of software design pattern where alogorithms are selected at runtime.
        */

        public static void RunProgram()
        {
            Console.WriteLine("STRATEGY PATTERN");
            Console.WriteLine("=============================>>>");

            IWeapon weapon = null;
            Character jinx = new Character();
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Choose a weapon for Jinx (1 = Sword, 2 = Axe, 3 = Club)");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default:
                        weapon = new NullObjectPattern();
                        break;
                }
                
                jinx.SetWeapon(weapon);
                jinx.Attack();

                i++;
            }
        }
    }
}
