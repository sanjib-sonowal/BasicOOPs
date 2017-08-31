using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class EmployeeLeaf : EmployeeComponent
    {
        public EmployeeLeaf(string name) : base(name)
        {}

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);
        }
    }
}
