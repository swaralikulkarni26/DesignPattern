using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPatter
{
   public  class Employees
    {
        private List<Employee>employees= new List <Employee>();
        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }
        public void Detatch(Employee employee)
        {
            employees.Remove(employee);
        }
        public void Accept (IVisitor visitor)
        {
            foreach(Employee employee in employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }

    public class Clerk : Employee
    {
        public Clerk() : base("swarali", 35000, 5)
        {

        }
    }

    public class Director : Employee
    {
        public Director() : base("Vijay Mali", 135000, 16)
        {

        }
    }

}
