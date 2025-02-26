//written by emilynn 
//2/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    //manager subclass
    public class Manager : Employee 
    {
        //class varibles 
        private int numberOfEmployeesManaged = 10;

        //gets and sets 
        public int NumberOfEmployees
        {

            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        //constructor calling the base 
        public Manager (string name, int salary, int numberOfEmployeesManaged) : base(name, salary)
        {
            this.numberOfEmployeesManaged = numberOfEmployeesManaged;
        }
        //ToString()
        public override string ToString()
        {
            string message = "";
            message += $" {Name} manages {NumberOfEmployees} employees.";
            return message;
        }
    }



    //engineer subclass
    public class Engineer : Employee
    {
        //class varibles 
        private string specialization = "n/a";

        //gets and sets 
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        //constructor calling the base
        public Engineer(string name, int salary, string specialization): base( name, salary)
        {
            this.specialization = specialization;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"{Name} has specialization of: {specialization}.";
            return msg;
        }
    }
}


