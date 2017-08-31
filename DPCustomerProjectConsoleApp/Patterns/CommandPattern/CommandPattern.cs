using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class CommandPattern
    {
        /*
         * Definition 1 : Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
         * Definition 2 : The command pattern is a behavioral design pattern in which an object is used to encapsulate all information needed to 
         * perform an action or trigger an event at a later time. This information includes the method name, the object that owns 
         * the method and values for the method parameters.
         */

        public static void RunProgram()
        {
            Console.WriteLine("COMMAND PATTERNS");
            Console.WriteLine("=============================>>>");

            // Existing stuff in house
            Light bedroomLights = new Light();
            AirConditioner acForRoom = new AirConditioner();

            // Creating the ON commands
            LightOn turnBedroomLightsOn = new LightOn(bedroomLights);
            ACOn turnOnAC = new ACOn(acForRoom);

            // Creating the OFF commands
            LightOff turnBedroomLightsOff = new LightOff(bedroomLights);
            ACOff turnOffAC = new ACOff(acForRoom);

            // Add the ON to the remote
            RemoteController remote = new RemoteController();
            remote.InsertNewOnCommand(turnBedroomLightsOn);
            remote.InsertNewOnCommand(turnOnAC);
            // Add the OFF to the remote
            remote.InsertNewOffCommand(turnBedroomLightsOff);
            remote.InsertNewOffCommand(turnOffAC);

            // Turn on the lights and AC
            remote.PressButtonOn(0);
            remote.PressButtonOn(1);

            // Turn off the lights and AC
            remote.PressButtonOff(0);
            remote.PressButtonOff(1);

            Console.WriteLine("*************************************************\n");
        }
    }
}
