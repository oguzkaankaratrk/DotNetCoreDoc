using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    internal class Pattern
    {
        //Type pattern - is kullanımı
        public void TypePattern()
        {
            object veri = "Gecler haram oldu bak bu aralar";

            if (veri is string mesaj)
            {
                Console.WriteLine(mesaj.ToUpper());
            }
            
            //veri değişkeni eğer string türünde ise, mesaj adında bir değişken oluşturulur. 

            object tc = 12345678901;

            if (tc is int lenthCal)
                Console.WriteLine(lenthCal.ToString());


            //tür kontrolü
            //veri dönüştürme
            //boş olup olmama
            //otomatik iplict
        }

        public void PatternsizKod()
        {
            object veri = "Gecler haram oldu bak bu aralar";

            if (veri != null)
            {
                Type t = veri.GetType();
                if(t.FullName == "system.string")
                {
                    string mesaj = (string)veri;
                    Console.WriteLine(mesaj.ToUpper());
                }
                
            }

        }

        //Switc ile doğrudan eşleşme
        public void ConstantPattern() 
        {
            int number = 2;

            string result = number switch
            {
                1 => "bir",
                2 => "iki",
                3 => "üç",
                4 => "dört",
                5 => "Beş",
                _ => "bilimiyor"

            };
        }

        //Büyüktür küçüktür gibi
        public void RelationalPattern()
        {
            int score = 85;

            string degree = score switch
            {
                < 50 => "Zayıf",
                < 70 => "orta",
                < 90 => "iyi",
                _ => "pekiyi"
            };

            Console.WriteLine(degree);
        }

        //Mantıksal pattern (and, or, not)
        public void LogicalPattern()
        {
            int x = 42;

            bool result = x is > 10 and < 100;
            Console.WriteLine(result);

            //and, or, not gibi mantıksal birden fazla mantıksal ifade aynı işlemde kontol edilebilir. 

        }

        //özellik deseni : Nesnelerin özellikleri ile eşleme
        //Eşleme yaptık. modern ve daha sade bir yaklaşımdır. 

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void PropertyPattern()
        {

            Person person = new Person { Name = "Ahmet", Age = 17 };

            if (person is { Age: > 18 })
            {
                Console.WriteLine("Reşit");
            }

            //propertysiz
            if(person != null && person.Age > 18)
            {
                Console.WriteLine("Reşit");
            }
        }

    }
}
