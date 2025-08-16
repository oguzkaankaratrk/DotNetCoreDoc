using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    //abstract class
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine($"Shape {Name}");
        }
    }
}
