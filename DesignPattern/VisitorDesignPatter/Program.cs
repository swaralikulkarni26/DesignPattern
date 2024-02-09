using System;

namespace VisitorDesignPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.Attach(new Clerk());
            employees.Attach(new Director());

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());

            Console.ReadKey();
        }
    }
}
