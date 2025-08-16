using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius;
        }
    }
}
