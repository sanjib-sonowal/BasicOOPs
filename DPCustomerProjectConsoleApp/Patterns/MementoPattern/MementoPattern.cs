using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class MementoPattern
    {
        /*
         * Definition 1 : Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.
         * Definition 2 : The memento pattern is a software design pattern that provides the ability to restore an object to its previous state 
         * (undo via rollback).
         */

        public static void RunProgram()
        {
            Console.WriteLine("MEMENTO PATTERN");
            Console.WriteLine("=============================>>>");

            IList<Memento> undos = new List<Memento>();
            Notepad notepad = new Notepad();
            Memento undo;

            // First Revision
            undo = notepad.SetText("Cool");
            undos.Add(undo);

            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            // Second Revision
            undo = notepad.SetText("Hello! I am sam. RockOn!");
            undos.Add(undo);

            Console.WriteLine("Currently in the notepad (after text change):");
            Console.WriteLine(notepad.GetText());

            Console.WriteLine("Issue the undo command!");
            notepad.Undo(undos[1]);

            Console.WriteLine("Currently in the notepad (after undo):");
            Console.WriteLine(notepad.GetText());

            Console.WriteLine("Issue the undo command again!");
            notepad.Undo(undos[0]);

            Console.WriteLine("Currently in the notepad (after undo again):");
            Console.WriteLine(notepad.GetText());

            Console.WriteLine("*************************************************\n");
        }
    }
}
