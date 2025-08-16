using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    public class HesapMakinesi
    {
        public void Hesaplama(int value)
        {
            Toplama(value);
            //hesap makinesi.
            Console.WriteLine("Hesaplama yapıldı.");
        }

        public void Toplama(int value)
        {
            int toplam = value;
            //hesap makinesi.
            Console.WriteLine("Toplama yapıldı.", value);
        }









    }
}
