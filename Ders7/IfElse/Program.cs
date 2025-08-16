//Şart sağlıyorsa işlem gerçekleşsin - eğer ; kısacası if koşulu sağlıyorsa yapılması gereknler
//şart sağlamıyorsa gerçekleştirsin. - değilse ; koşulu sağlamıyorsa yapılamsı gerekenler
using System.Security.AccessControl;
/*1. bölüm*/
//int a = 5;
//int b = 3;

//if (a + b > 10)//sepet
//{
//    Console.WriteLine("hediye çeki kazandınız");
//    Console.WriteLine("hediye çeki kazandınız");
//}
//else
//{
//    Console.WriteLine("alışverişe devam et.");
//}

/*2. bölüm*/
////ikinci kullanımı 
//if (a + b > 10)//sepet
//    Console.WriteLine("hediye çeki kazandınız");
//else
//    Console.WriteLine("alışverişe devam et.");

//eşitlik testi -> eşitlik opratörü -> == : iki değerin birbirine eşit olup olmadığını kontrol eder.
//// a == b  : a b ye eşit mi.
///dikkat : = operatörü ile karıştırılmamalıdır. = operatörü bir değişkene değer atar.
///a = b  // a nın değeri artık b.
///

//int a = 5;
//int b = 3;
//int c = 124;

//a = b;



//Console.WriteLine(a); // 3

/*3. bölüm*/
//C# Ta girintilemeye önem verilmez. Satır hizası yanlış olsada kod doğru çalışır. 
//Girintiler kodun okunulabilirliğini artırmaktadır.
// süslü parantez neden kullanılabilir : kod okunulurluğunu artırır, Hata önlemek için kullanılır.  Yazılımcılar arasında ortak bir kod yazım şeklidir. 

//intin dotnette kullanımı
//age = int(input("Enter your age: "))  # Yaş girişi al ve integer'a çevir
//print(f"You are {age} years old.")
//Console.WriteLine("Enter your age: ");
//string input = Console.ReadLine();//kullanıcıdan bilgi alır. 
//int age = int.Parse(input);// pars stringi inte dönüştirir
//Console.WriteLine("You are {age} years old.");

/*4. bölüm*/
//&& -> ve demek yani and. bu şartın gerçekleşmesi için iki koşulunda doğru olması gerekir.

//int number = 15;
//if (number > 10 && number < 20) // Hem 10'dan büyük hem 20'den küçük
//{
//    Console.WriteLine("Number is between 10 and 20.");
//}


//bool askerStatus = false;
////bool iki değer alır true veya false. 
//int yas = 27;

//if (yas > 18 && askerStatus == true)
//    Console.WriteLine("Yurt dışına çıkabilirsiniz");
//else
//    Console.WriteLine("jandarmaya haber ver");

// || -> veya or denir. şartın gerçekleşmesi için birinin gerçekleşmesi yeterli. 

int yas = 17;
bool veliFelmismi = true;

if (yas > 18 || veliFelmismi == true)
    Console.WriteLine("Yurdışına çıkabilirsiniz.");
else
    Console.WriteLine("yurtdışına çıkamazsın");

//Biz main fonksiyonunun içerisini yani progra.cs dosyasını sade bırakmaya çalışırız.
//tüm kodlar progra.cs de çalışacağı için buranın sade olması kodun okunulurluğu açısından önemlidir.
//Bunları layer, class, methodlar aracılığı ile sadeleştireceğiz. 
