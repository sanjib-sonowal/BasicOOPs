using EFConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities dbContext = new EmployeeDBEntities();

            #region SIMPLE CRUD OPERATIONS
            Console.WriteLine("CRUD Operations on Employees\n");
            // Get All Employees
            Console.WriteLine("GET");
            Console.WriteLine("*******************************************************************");
            List<Employee> empList = dbContext.Employees.ToList();
            foreach (var empItem in empList)
            {
                Console.WriteLine("Name : " + empItem.Name + ", Job Description : " + empItem.JobDescription + ", Department : " + empItem.Department);
            }

            Console.WriteLine("\n");

            // Create an Employees
            Console.WriteLine("CREATE");
            Console.WriteLine("*******************************************************************");
            Employee newEmp = new Employee();
            newEmp.Name = "Mike";
            newEmp.JobDescription = "Contract Engineer";
            newEmp.Number = "T101";
            newEmp.Department = "IT";
            dbContext.Employees.Add(newEmp);
            int Id = dbContext.SaveChanges();

            if (Id == 1)
            {
                Console.WriteLine("Name : " + newEmp.Name + ", Job Description : " + newEmp.JobDescription + ", Department : " + newEmp.Department);
            }

            Console.WriteLine("\n");

            // Update an Employees
            Console.WriteLine("UPDATE");
            Console.WriteLine("*******************************************************************");
            Employee updateEmp = dbContext.Employees.SingleOrDefault(f => f.Number == "T101");
            updateEmp.JobDescription = "Contract Engineer Role";
            if (updateEmp != null)
            {
                dbContext.Entry(updateEmp).State = EntityState.Modified;
                dbContext.SaveChanges();
            }

            updateEmp = dbContext.Employees.SingleOrDefault(f => f.Number == "T101");
            Console.WriteLine("Name : " + updateEmp.Name + ", Job Description : " + updateEmp.JobDescription + ", Department : " + updateEmp.Department);

            Console.WriteLine("\n");

            // Delete an Employees
            Console.WriteLine("DELETE");
            Console.WriteLine("*******************************************************************");
            Employee deleteEmp = dbContext.Employees.SingleOrDefault(f => f.Number == "T101");
            string Name = deleteEmp.Name;
            string Number = deleteEmp.Number;
            dbContext.Entry(deleteEmp).State = EntityState.Deleted;
            dbContext.SaveChanges();

            if (dbContext.Employees.Where(f => f.Number == "T101") != null)
            {
                Console.WriteLine("Name : " + Name + " with Number : " + Number + " has been deleted.");
            }
            #endregion

            #region STOREDPROCEDURES IN EF
            dbContext.UpdateEmployee("101");
            #endregion

            /* STOPS AUTOMATICALLY EXIT */
            Console.ReadLine();
        }
    }
}
