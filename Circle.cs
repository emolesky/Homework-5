using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Circle : Shape
    {
        //class varibles
        private double radius = 0.0;

        //gets and sets
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Circle(string color, double radius) : base(color)
        {
            this.radius = radius;
        }

        //area method 
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        //ToString
        public override string ToString()
        {
            return $"{Color} Circle: \n Radius: {Radius} \n Area: {GetArea()}";
        }
    }



    //retangle subclass
    public class Retangle : Shape
    {
        private double height = 0.0;
        private double width = 0.0;

        //gets and sets 

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        //constructor calling base 
        public Retangle(string coloe, double width, double height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        //ToString 
        public override string ToString()
        {
            return $"{Color} Rectangle: \nWidth: {Width} \nHeight: {Height} \nArea: {GetArea()}";

        }

    }
}
