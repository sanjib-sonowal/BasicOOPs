﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class EmployeeComposite : EmployeeComponent
    {
        private IList<EmployeeComponent> employees;

        public EmployeeComposite(string name) : base(name)
        {
            employees = new List<EmployeeComponent>();
        }

        public void AddEmployee(EmployeeComponent e)
        {
            employees.Add(e);
        }

        public void RemoveEmployee(EmployeeComponent e)
        {
            employees.Remove(e);
        }

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);
            foreach (EmployeeComponent e in employees)
            {
                e.PrintSupervisorOf(spacing + 1);
            }
        }
    }
}
