
using System.Diagnostics.Metrics;

///1. Değer türleri
/// Value types(Değer türler) : System.ValueTypes tan türetilir.
///Değer türler bellekte değerlerini doğrudan içerir.
///Stack(yığın) bellekte saklanır.Heapte (küme bellek) yer kaplamaz.
///Garbage collection sürecine dahil edilmezler bu yüzden performans açısından hızlıdırlar. 
///Boxing ve unboxing, değer türlerinin referans türleri ile birlikte kullanıldığı durumları açıklar.
///

//int, float, bool, char, double
int number = 43; // değer doğrudan stack bellekte saklanır.


///2. Değer türlerinin türleri
///struct : küçük veri kümelerini saklamak için kullanılır. 
///enum : belirli sabitleri temsil eden adlandırılmış tam sayıyı temsil eder. 
///


Coords point = new Coords(20,10);
Console.WriteLine($"Koordinatlar: ({point.x}, {point.y})");   

Day day = Day.Monday;
Console.WriteLine($"BUGÜN:{day}");

///3.Değer türlerin özellikleri
///a.Mühürlüdür(sealed) : Değer türler başka bir türden türetilemez ve başla bir türe türetme yapamaz.
///örneğin, int türü bir structtır ve ondan türetme yapamazsın. 
///Arabirim Uygulayabilir:Değer türleri arabirimleri uygulayabilir.
///


///Boxing ve unboxing
///c# dilinde değer türleri(value types) ile referans türleri arasında dönüşüm yapmak için kullanırız. 
///Boxixng : değer türünü(int ...) bir referans (string) türüne dönüştürme işlemidir. 
///bu işlem değer türünü heap bellekte bir nesne içine sarar. 
///

//değer tür referans türe çevrildi
int value = 42;
object boxedVlue = value;
Console.WriteLine(boxedVlue);

// referasn tür değer türe çevirildi.
object boxedValue = 42;
int values = (int)boxedValue;   
Console.WriteLine(values);