using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPatter
{
  public  class Employee : Element
    {
        private string name;
        private double income;
        private int vacationDays;

        public Employee(string name, double income, int vacationDays)
        {
            this.name = name;
            this.income = income;
            this.vacationDays = vacationDays;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Income
        {
            get { return income;}
            set { income = value; }
        }
        public int VacationDays
        {
            get { return VacationDays; }
            set { VacationDays = value; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
       
    }
}
