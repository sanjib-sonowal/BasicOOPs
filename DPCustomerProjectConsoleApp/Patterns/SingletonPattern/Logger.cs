using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    // Singleton Class
    public class Logger
    {
        private static Logger logger = null;

        // Private constructor so this class cannot be instantiated.
        private Logger() { }

        public static Logger GetInstance()
        {
            // YODA Expression
            if(null == logger)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void WriteToFile(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
