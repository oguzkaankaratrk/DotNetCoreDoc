using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    internal class UsingIsWithList
    {
        public void Fruit()
        {
            object data = new List<string> { "elma", "armut", "mandalina" };

            if (data is List<string> meyveler)
            { 
                Console.WriteLine($"Meyvelerin sayısı: {meyveler.Count}");
                foreach (var meyve in meyveler) { 
                Console.WriteLine(meyve); //alt alta elma, armut, mandalina yazar.
                }
            }
            else
            {
                Console.WriteLine("Liste değil");
            }

            //data is List<string> meyveler -> bu kod aşağıdaki koda eşttir. yani is hem null kontrolü, hemde tip kontrolü yaptı.
            if (data != null && data.GetType() == typeof(List<string>))
            {
                var meyvelerr = (List<string>)data;
            }
    }
}
