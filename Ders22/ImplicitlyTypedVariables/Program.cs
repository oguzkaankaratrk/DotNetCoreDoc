
using System.Net.Cache;
using System.Xml.Linq;

///Implicitly Typed Variables : Örtük türler denilebilir.
///Var : Bir değişkenin türünü açıkça belirlemek yerine var anahtar kullanarak tanımlanır.
///Derleyici otomatik olarak türünü atar. 
///Var ile türü biz belirlemeyiz, türü derlerleyici otomatik olarak belirler. 
///local değişkenler iöin sadece kullanılı. sınıf(class) veya methodlar için kullanılmaz.
///linq sorgularında kullanılır.

var number = 34; //int
var name = "vbnmö";

///Anonymous Types 
///Kısa süreli işlemlerde kullanılır.
///Geçici veri tutmak için yeni bir tür tanımlamak yerine anononim türler kullanılır.
///

var person = new { Name = "Ali", Age = 30 };
//person name ve age i vardır ancak başka bir method veya sınıfa aktarılamaz. 


///Nullable Value Type
///bir tür boş olabilir mi olamazmı . //mail zorunlu mu değilmi.
/// normalde int float bool ... null değeri alamaz. ama c# ta ? ile boş olabiliri. 
/// intt?, string?, bool? ....

//validasyon
//string? address = null;

//db
//string? address = null;

string? address = null; //adres bilgisi henüz yok.

if (address == null)//string.IsNullOrEmpty(name)
{
    Console.WriteLine("Dayı sipariş verirken lütfen adresinizi giriniz. Burada zorunlu değil.");
}
else 
{ 
    Console.WriteLine("Ana adres olarak kaydedildi. Siparişiniz byu adrese gelecektir."); 
}


