using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    // Subject are lets say youtube channel.
    public class YoutubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>(); 

        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void UnSubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }

        public void NotifySubscriber()
        {
            foreach(ISubscriber s in subscribers)
            {
                s.Notify();
            }
        }
    }
}
