using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Payment
    {
        public bool ProcessPayment(string cartNumber, string cuponCode)
        {
            string validCupon = "Trend10";//Geçerli kupon kodu
            if (cuponCode == validCupon )
            {
                Console.WriteLine("Kupon kodu doğru. Alışverişiniz tamamlandı!");
                return true;
            }
            else
            {
                Console.WriteLine("Kupon kodu geçersinz. Ödeme Başarısız.");
                return false;
            }
        }
    }
}
