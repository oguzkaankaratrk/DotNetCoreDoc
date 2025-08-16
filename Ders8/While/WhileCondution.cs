using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class WhileCondution
    {
        ////
        ///.net de while ve do...while genel olarak benzerdir. 
        ///fakat kullanıldıkları saryolar farklıdır.
        /// <summary>
        /// .net de while ve do...while genel olarak benzerdir. 
        /// </summary>
        /// 

        public void CounterWhile()
        {
            int counter = 0;
            while (counter < 10)//kontrol mekanizması
            {

                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++; // Sayaç her adımda 1 artırılır
            }
        }

        public void DoWhile()
        {
            //Do while
            //Do ... while döngüsü kodu enaz birkez çalıştırır, ardından koşulu kontrol eder.
            //koşul false olsabile döngü bir kez çalışır. 

            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);//kontrol mekanizması.

            //Sayaç 10 a ulaşana kadar hello world yazdırılacak.
        }

        public void SonsuzDongu()
        {

            ///while                             ///Do..whilw
            ///Döngüden önce kontrol edilir.     /// Döngüden sonra kontrol edilir.
            ///Kşul yanlışsa hiçbiri çalışmaz.   /// Koşul yanlışsa bir kez kalışır
            ///

            int counter = 0;


            while (counter < 10)
            {
                Console.WriteLine("Sonsuz döngü");
                //counter++;
                //sayacı kaldırırsak sonsuz döngüye girer.
            }
        }


        /// Kullanıcıdan en az bir bilgi istediğimiz durumda do while kullanılır.

        public void doWhile()
        {

            string userName;

            do
            {
                Console.WriteLine("Kullanıcı adınızı giriniz : ");
                userName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(userName));

            Console.WriteLine($"Hoş geldin, {userName}!");


            /// işlem yapıldıktan sonra devam edip edilmemesi gereken durumlarda kullanılır.
            /// 

            string answer;

            do
            {
                Console.WriteLine("biteane işlem gerçekleştirildi");

                Console.Write("dEVAM ETMEK İSTİYOR MUSUN Y / N");

                answer = Console.ReadLine();

            } while (answer == "y");

            Console.WriteLine("Devam ediyoruz");


            /// Bir kaynak başlatılıp durdurulması gereken durumlarda kullanılır. 

            bool databaseAccessStatus;

            do
            {
                Console.WriteLine("Kaynak başlatılıyor...");
                // Simülasyon: rastgele başarı veya başarısızlık
                databaseAccessStatus = new Random().Next(0, 2) == 1;

                if (!databaseAccessStatus)
                {
                    Console.WriteLine("Kaynak başlatılamadı. Tekrar deneniyor...");
                    Thread.Sleep(1000); // 1 saniye bekle
                }

            } while (!databaseAccessStatus);

            Console.WriteLine("Kaynak başarıyla başlatıldı.");


        }



    }



}
