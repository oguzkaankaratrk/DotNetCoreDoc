using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordClass
{
    internal record class Adam
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Adam { Name = Mahsun Karaca, Age = 32 }
        //Record türü, otomatik olarak property nameleri ve değerlerini güzel bir formatta döndürür.
    }
}
