//Bana trend yolda bir ürün yap .
//Ürünün açıklaması ismi kodu id si olacak
//bunları baskete ekleyince baskete eklendi diyecek
//Sonra kart bilgilerini gircez sorsun bize ödemeye gidilsinmu
//Eğer ödemeyi seçerse kart bilgilerini girecez
//Hatta coupon kodunu girecez
//Eğer coupon kodu doğru ise alış verisiniz tamamlandı yazacak.


using Example1;

class Program
{
  static void Main(string[] args)
    {
        // 1. Ürün oluşturma
        Product product1 = new Product(1, "Ayakkabı", "Spor Ayakkabı", "A123");
        Product product2 = new Product(2, "Tişört", "Yazlık Tişört", "T456");

        //2. Sepet işlemşeri
        Basket basket = new Basket();
        basket.AddToBasket(product1);//1.ürün eklendi
        basket.AddToBasket(product2);//2. ürün eklendi

        //Sepet göster
        basket.ShowBasket();

        //3. Ödeme işlemleri
        Console.WriteLine("\nÖdemeye devam etmek istiyor musunuz? (E/H): ");
        string paymetChoice = Console.ReadLine();

        if (paymetChoice.ToUpper() == "E")
        {
            Console.WriteLine("\nKart Numaranızı Girin: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Kupon Kodunu Girin: ");
             string couponCode = Console.ReadLine();

            Payment payment = new Payment();
            payment.ProcessPayment(cardNumber, couponCode);
        }
        else
        {
            Console.WriteLine("Siparişiniz iptal edildi.");
        }
    }
}