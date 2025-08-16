// namespace
//amacı : kodun organize edilmesini ve çakışmasını önlemektir.
//Namespace sayesinde biz yazdığımız kodu başka satfalarda kullanıyoruz.
//using ile kullanacağımız namespaceyi 
//Kendi namespacelerimizi tanımlaya biliriz. Büyük projelerde kodun düzenini ve kapsamını kontrol eder.
//namespacelerdeki kodlara ulaşmak için . (nokta) işaretini kullanırı.



using Introduction;
using NameSpaces;
using payment;

Console.WriteLine("Hello, World!");

//bu alan siparişler alanı
Order order = new Order();
order.Name = "BAKLAVA";

//Bu alan Ödeme alanı

GarantiBankKartBilgileri garantiBankKartBilgileri = new GarantiBankKartBilgileri();

System.Int128 cyripyo = 1234567890;

string name = "";
//hatayı çöz
benimNameSpace.Mushab(name);

