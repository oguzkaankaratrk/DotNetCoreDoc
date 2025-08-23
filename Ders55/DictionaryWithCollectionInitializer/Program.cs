//Dictionary<TKey,TValue> başlatmanın iki yolu vardır. 
//Ve aralarındaki en kritik fark, tekrarlanan elemanların nasıl ele alındığıdır.
//1. Koleksiyon başlatıcı(add çağrısı) - çift süslü parantez.

var d1 = new Dictionary<int, string>
{
    {111,"Ali"},
    {222, "Mehmet" },
    {333, "Halit ziya uşalıgil" }
};
//Tekrarlanan değer varsa dictionary de ArgumentException fırlatır.
var d2 = new Dictionary<int, string>
{
    {111,"Ali"},
    {111, "Mehmet" },//Run timede an item with the same key has already been added.
};

//Ne zaman tercih edilir? eğer başlangıç verilerinizde yanlışlıkla overwrite olmasın hata fırlatsın istiyorsanız bunu kullan. 


//------------------------------------------------------------
//2. Dizi başlatıcı(index initializer) - Köşeli parentez ile
//Dizine atama yapar, derleyici dictionary[key] = value üretir.
var d3 = new Dictionary<int, string>
{
    [111] = "ALİ",
    [222] = "VELİ",
    [333] = "DİNO",
};
//Tekrarlanan key varsa, üzerine yazar(overwrite) en son değer geçerli olur.

var d4 = new Dictionary<int, string>
{
    [111] = "ALİ",
    [111] = "VELİ",//Hata yok, 111 veli.
};
//Ne zaman tercih edilir. Başlangıçta en son gelen kazansın davranışını istiyorsanız, bunu kullan.

//Modern söz dizimi(c# 9 ve üzeri)
//daha kısa yazarsın
Dictionary<int, string> d5 = new()
{
    [111] = "ALİ",
    [222] = "VELİ",
    [333] = "DİNO",
};

//kapasite ve karşılaştırıcı ile başlatma
//baştan kapasite vermek yeniden boyutlandırmayı azaltır.
//capacity: 100 -> şayet biz kaç tane eleman girileceğini biliyorsak bunu kullanabiliriz.
//StringComparer.OrdinalIgnoreCase : Dictionay nin anahtarları karşılaştırılırken bir eşitlik karşılaştırıcısı(IEqualityComparer<T>) kullanılır.
//Normalde Dictionary<string, ....> büyük küçük harfe duyarlıdır("Ali", "ali" farklı anahtarlar sayılır.)
//bunu kullanırsan case-insensitive olur. 
//StringComparer.CurrentCultureIgnoreCase : Çalıştığın bilgisayarın dili/kültürüne göre davlarnır. 
//StringComparer.InvariantCultureIgnoreCase : Kültür bağımsız ama uluslararası string karşılaştırması yapar daha ağırdır.
//
var d6 = new Dictionary<string, int>(capacity: 100, comparer: StringComparer.OrdinalIgnoreCase)
{
    ["en"] = 1,
    ["fr"] = 2,
};

//iç içe bailatma - liste dizin karışık

var groups = new Dictionary<string, List<int>>
{
    ["odd"] = new() { 1, 3, 5 },
    ["even"] = new() { 2, 4, 6 }
};

//sözlük içinde sçzlük

var menü = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase)
{
    ["en"] = new()
    {
        ["home"] = "Home",
        ["Cart"] = "Cart"
    },
    ["tr"] = new()
    {
        ["home"] = "Anasayfa",
        ["cart"] = "sepet"
    }
};

///Pratik öneriler
///Hata yakalamak istiyorsanız yanlışlıkla aynı anahtar eklenmesini engellemek istiyorsanız key value add kullanın
///Bile isteye overwrite istiyorsanız [key] = value kullanın
///CpncurrentDictionary()eş zamanlı sözlük) gibi add olmayan tiplere : index intializer ([key] = value) tercih edin
///performans için kapasite verin capacity: 100, comparer: StringComparer.OrdinalIgnoreCase
///

