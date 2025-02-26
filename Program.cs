//written by emilynn 
//2/25/25
using System.Drawing;

namespace ShapesAndAreas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle aCircle1 = new Circle("Red", 2.5);
            Circle aCircle2 = new Circle("Blue", 5.0);

            Retangle aRetangle1 = new Retangle("Orange", 2.0, 3.0);
            Retangle aRetangle2 = new Retangle("Greem", 6.0, 2.0);

            Console.WriteLine(aCircle1.ToString());
            Console.WriteLine(aCircle2.ToString());
            Console.WriteLine(aRetangle1.ToString());
            Console.WriteLine(aRetangle2.ToString());

        }
        
    }
}
