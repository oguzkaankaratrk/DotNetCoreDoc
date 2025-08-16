using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritancePart2
{
    //Sealed Class - Mühürlenmiş  sınıf
    //Bu class başka bir classın onları inheritance etmesine izin vermez. 

    public sealed class Utility
    {
        public void PrintMassege() => Console.WriteLine("Utilty Method");
    }
}
