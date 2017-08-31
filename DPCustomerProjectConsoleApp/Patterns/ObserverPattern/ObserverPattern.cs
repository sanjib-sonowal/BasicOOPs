using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    /* 
     * Definition 1 : Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
     * Definition 2 : The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, 
     * called observers, and notifies them automatically of any state changes, usually by calling one of their methods.
     * Observer Pattern : Observer are nothing but Users and Subject are things that we use like a youtube channel, twitter, facebook etc.
     */

    public static class ObserverPattern
    {
        public static void RunProgram()
        {
            Console.WriteLine("OBSERVER PATTERNS");
            Console.WriteLine("=============================>>>");
            YoutubeChannel jinxLabs = new YoutubeChannel();
            ISubscriber mike = new User();
            ISubscriber john = new User();
            ISubscriber rocky = new Moderator();

            jinxLabs.Subscribe(mike);
            jinxLabs.Subscribe(john);
            jinxLabs.Subscribe(rocky);

            jinxLabs.NotifySubscriber(); // When upload a new video to channel.

            Console.WriteLine("Rocky UnSubscribe");
            jinxLabs.UnSubscribe(rocky);

            jinxLabs.NotifySubscriber();

            Console.WriteLine("*************************************************\n");
        }
    }
}
