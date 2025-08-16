using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    internal class Founder : Manager
    {
        public void Opreation()
        {
            Console.WriteLine($"{Name} is preationing...");
        }
    }
}
