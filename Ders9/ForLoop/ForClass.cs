using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class ForClass
    {
        public void ForKonu()
        {
            //for (initialization; condition; iteration)
            //initialization : başlangıç değeri
            //condition : Döngü ne kadar devam edecek
            //iteration : artırma azaltma
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        public void ForeachKonu()
        {
            //Bir koleksiyonun tüm elemanlarını işlemek için kullanılır. 
            string[] menuName = { "Yemek", "İçecek", "Tatlı", "Salata" };

            foreach (string name in menuName)
            {
                //String içerisine değişken koymak istiyorsak $ işareti kullanacağız.
                //Değişken süslü parantez içerisinde yer almalıdır.
                //Stringi dinamik hale getirir.
                Console.WriteLine($"Menü ismi:{name}");
            }
        }
    }
}
