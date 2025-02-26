//written by emilynn 
//2/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public abstract class Shape
    {//class varibles
        private string color = "n/a";

        //gets and sets 
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //empty constructor
        public Shape() : this("n/a")
        { }

        //full constructor 
        public Shape( string aColor)
        {
            this.color = aColor;

        }
        public abstract double GetArea();

        public override string ToString()
        {
            return $"{Color} Shape";
        }

    }
}
