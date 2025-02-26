using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    //dog subclass
    public class Dog: Animal
    {
        public override string ToString()
        {
            return " Bark":
        }
    }

    //cat subclass
    public class Cat : Animal
    {
        public override string ToString()
        {
            return "meow";
        }
    }
}
