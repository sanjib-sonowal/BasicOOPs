using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            // Sign up for a facebook account.
            Users = new LinkedList<string>();
            Users.AddLast("Jinx");
            Users.AddLast("John");
            Users.AddLast("Mike");
            Users.AddLast("Olga");
            Users.AddLast("Kristen");
        }

        public IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }

    public class Twitter : ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] { "Jessica", "Bell", "Toni", "Prachi" };
        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}
