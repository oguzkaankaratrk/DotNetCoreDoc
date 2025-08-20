using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerPropertyInitializerIndexInitializer
{
    public class StudentName
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Poem { get; set; }


        //Parametresiz ctor
        //Object Initializer
        public StudentName()
        {
            
        }

        public StudentName(string first, string last, string poem)
        {
            FirstName = first;
            LastName  = last;
            Poem = poem;
        }

        public override string ToString() => FirstName + " " + Id;
    }
}
