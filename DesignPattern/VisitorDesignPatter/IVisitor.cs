using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPatter
{
   public interface IVisitor
    {
        void Visit(Element element);
    }

    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee=element as Employee;

            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days:{2}", employee.GetType().Name, employee.Name, employee.VacationDays);
        }
    }
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            employee.Income *= 0.10;
            Console.WriteLine("{0} {1}'s new Income:{2}", employee.GetType().Name, employee.Name, employee.Income);
        }
    }
}
