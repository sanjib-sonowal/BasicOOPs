using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class EmployeeComponent
    {
        public string Name { get; set; }

        public EmployeeComponent(string name)
        {
            this.Name = name;
        }

        public virtual void PrintSupervisorOf(int spacing)
        {
            for (int i = 0; i < spacing; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Name);
        }
    }
}
