using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public delegate bool IsPromotable(Employee emp);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promote(List<Employee> empList, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee emp in empList)
            {
                // THIS PROMOTE LOGIC IS HARDCODED to "Experience >= 5". SO Promote() IS NOT REUSABLE IN EVERY SCENARIO.
                //if (emp.Experience >= 5)
                if(IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted.");
                }
            }
        }

    }
}
