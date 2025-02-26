using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesCars
{
    //car subclass
    public class Car : Vehicle
    { //class variables
        private int numberOfDoors = 4;

        //gets and sets
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }
        }

        // constructor calling base
        public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
        {
            this.numberOfDoors = numberOfDoors;
        }
        //ToString override
        public override string ToString()
        {
            string msg = "";
            msg += $"{Year} {Make} {Model} with {numberOfDoors} doors.";
            return msg;
        }
    }
    //motorcycle subclass
    public class Motorcycle : Vehicle
    { //class variables
        private bool hasSidecar = false;

        //gets and sets
        public bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }
        // constructor calling base
        public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
        {
            this.hasSidecar = hasSidecar;
        }

        //ToString
        public override string ToString()
        {
            string msg = "";
            msg += $"{Year} {Make} {Model} (Has Sidecar: {hasSidecar})";
            return msg;
        }
    }
}
