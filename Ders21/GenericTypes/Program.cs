///Generic Types
///Bir yapı kuruyorsun. Belirlediğin kurala göre istediğin kadar veri göndere biliyorsun.
///<T>,List<T>,Dictionary<TKey, TValue>
///generic type ile boxing ve uhnboxinge gerek kalmaz. 
///daha performanslı ve güvenli kodlar yazarız. 
///derleme anında güvenliği garanti eder. 
///


List<string> urunler = new();
urunler.Add("Kalem");
urunler.Add("Kağıt");
///istediğin kadar add de
//stringsList.Add(55);///hata verir çünkü string tipinde bir veri gerekiyor.

foreach (var item in urunler)
{
    Console.WriteLine(item);//ALTA GEÇER
    Console.Write(item);//ALTA GEÇMEZ
}


List<int> intList = new List<int>();
intList.Add(1);

List<char> chars = new List<char>();
chars.Add('s');
chars.Add('e');


