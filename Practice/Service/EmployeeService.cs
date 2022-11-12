using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class EmployeeService:IEmployeeService
    {
        public int GetFilterEmployeeCount(DateTime start, DateTime end, double salary)
        {

            Employee[] employees = GetEmployee();
          

            int empCount = 0;

            foreach (Employee emp in employees)
            {
                if((emp.Birthday>start && emp.Birthday<end) && emp.Salary > salary)
                {
                    empCount++;
                }
                
            }
            return empCount;
        }
         private Employee[] GetEmployee()
        {

            Employee emp1 = new Employee(DateTime.Now.AddDays(20));
            emp1.Salary = 5000;
            Employee emp2 = new Employee(DateTime.Now.AddDays(15));
            emp2.Salary = 7500;
            Employee emp3 = new Employee(DateTime.Now.AddDays(-20));
            emp3.Salary = 1500;
            Employee emp4 = new Employee(DateTime.Now.AddDays(-10));
            emp4.Salary = 800;
            Employee emp5 = new Employee(DateTime.Now);
            emp5.Salary = 1000;

            Employee[] employees = { emp1, emp2, emp3, emp4, emp5 };
            return employees;
        }
    }
}
