//written by emilynn
//2/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Employee
    {
        //class varibles
        private string name = "n/a";
        private int salary = 0;

        //gets and sets 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public Employee() : this ( "n/a", 0)
        {
            //empty constructor 
        }

        //full constructor 
        public Employee (string aName, int aSalary)
        {
            this.name = aName;
            this.salary = aSalary;

        }
        //ToString()
        public override string ToString()
        {
            string message = "";
            message += $"Employee: {name} Salary: {Salary}.";
            return message;
        }
    }
}
