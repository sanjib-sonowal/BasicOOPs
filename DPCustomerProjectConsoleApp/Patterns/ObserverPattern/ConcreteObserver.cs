using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Users/Observers has been updated about new video.");
        }
    }

    public class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderators need to review new video.");
        }
    }
}
