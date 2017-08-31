using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class FacebookIterator : IIterator
    {
        private LinkedList<string> Users;
        private int position;

        public FacebookIterator(LinkedList<string> users)
        {
            this.Users = users;
            this.position = 0;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(position);
        }

        public void First()
        {
            position = 0;
        }

        public bool IsDone()
        {
            return position >= Users.Count;
        }

        public string Next()
        {
            return Users.ElementAt(position++);
        }
    }

    public class TwitterIterator : IIterator
    {
        private string[] Users;
        private int position;

        public TwitterIterator(string[] users)
        {
            this.Users = users;
            position = 0;
        }

        public string CurrentItem()
        {
            return Users[position];
        }

        public void First()
        {
            position = 0;
        }

        public bool IsDone()
        {
            return position >= Users.Length;
        }

        public string Next()
        {
            return Users[position++];
        }
    }
}
