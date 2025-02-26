//written by emilynn 
//2/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Animal
    {
        //class varibles 
        private string name = "n/a";

        //gets and sets 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Animal():this("n/a")
        {
            //empty constructor 
        }
        public Animal(string aName)
        {
            this.Name = aName;
        }

        public string MakeSound()
        {
            return "Some generic animal sound";

        }
        public override string ToString()
        {
            string msg = "";
            msg += $" Animal: {name}, Sound: {MakeSound}";
            return msg;
        }

    }
}
