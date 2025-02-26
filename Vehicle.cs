using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesCars
{
    public class Vehicle
    { //Class variables
        private string make = "n/a";
        private string model = "n/a";
        private int year = 0;

        //gets and sets
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public Vehicle() : this("n/a", "n/a", 0)
        {
            //empty constructor
        }
        //full constructor
        public Vehicle(string aMake, string aModel, int aYear)
        {
            this.Make = aMake;
            this.Model = aModel;
            this.Year = aYear;
        }
        //ToString()
        public override string ToString()
        {
            string msg = "";
            msg += Year + Make + Model;
            return msg;
        }
    }
}
