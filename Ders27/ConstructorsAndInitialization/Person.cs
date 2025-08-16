using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInitialization
{
     class Person
    {
        #region Required Keyword (Zorunlu properties(özellik))

        //required anahtar kelimesi ile belirtilen propertiesler,  nesne oluşturulurken ayarlanması zorunludur.
        //requred properties
        public required string Name { get; set; }//get : veri al, set : veriyi verecez.
        // properties
        public required string LastName { get; set; }
        //field
        public int Age;





        #endregion
    }
}
