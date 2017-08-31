using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class RemoteController
    {
        public IList<ICommand> turnOnCommands = new List<ICommand>();
        public IList<ICommand> turnOffCommands = new List<ICommand>();

        public void InsertNewOnCommand(ICommand command)
        {
            turnOnCommands.Add(command);
        }

        public void InsertNewOffCommand(ICommand command)
        {
            turnOffCommands.Add(command);
        }

        public void PressButtonOn(int buttonNumber)
        {
            turnOnCommands[buttonNumber].Execute();
        }

        public void PressButtonOff(int buttonNumber)
        {
            turnOffCommands[buttonNumber].Execute();
        }
    }
}
