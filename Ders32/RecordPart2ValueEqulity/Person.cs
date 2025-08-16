using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordPart2ValueEqulity
{
    public class Person
    {

        //classlar = OOP nin temel taşıdır. 
        // içerisinde Entityler, Methodlar, Propertyler ... bulundurur. 
        public string Name { get; set; }

        //mehodlar = Bir işlemi gerçekleştiren koddur.

        
        public void SelamVer(string userName)
        {
            Console.WriteLine($"Selamün aleyküm {userName = Name}");
        }

        //struct lar = Classa çok benzer ama hafif işlemler ve küçük veri yapıları için kullanılır. 

        public struct Koordinat
        {
            public int X;
            public int Y;
        }

        //birsürü işlemler yazdır
    }
}
