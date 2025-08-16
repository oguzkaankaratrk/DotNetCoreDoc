using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordClass
{
    //manuel override(Aşırı yüklenme)
    internal class Insan
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            //Adam { Name = Mahsun Karaca, Age = 32 }
            return $"Insan {{ Name = {Name}, Age = {Age}}}";
        }
    }
}
