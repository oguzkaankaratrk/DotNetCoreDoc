
using System.Runtime.InteropServices;

///Static class
///Normal class gibidir ama new ile instance(örnek) oluşturulamaz
///yani var obj new Utility(); yazamazsın, derleme hatası verir
///içinde sadece statik üyeler(property, method, field) bulundurur. 
///Sealeddir ->  başka sınıftan türeyemez, oda başka sınıftan türeyemez. 
///
///
static void Main()
{
    UtilityClass.BizeLazimMethod();
    Console.WriteLine(UtilityClass.Square(5));
    double dub = -3.14;
    Console.WriteLine(Math.Abs(dub)); //+3.14


    Logger.Log("Program başlatıldı");
}
public static class UtilityClass
{
    public static void BizeLazimMethod()
    {
        Console.WriteLine("Started static method");
    }

    public static int Square(int x) => x * x;

    

}


///Neden static class
///İşlemler yapan helperlar yani yardımcı sınıflar yazarken kullanımına uygundur.
///örneğin system.Math, system.Convert bunların tamamı static clastır. 
///Bu classlar state tutmasına geğerk yoktur. işilemler yapar. yukarıda math örneği verdik bak
///.
///statik class içerisinde statik constructor tanımlanabilir. 
///bu ctor paremetresiz olur, bir kere çalışır ömrü bitene kadar devam eder, 
///class içerisindeki statik alanları başlatmak için kullanılır.
///
public static class Logger
{
    public static string LogFilePath;

    static Logger()
    {
        LogFilePath = $"log_{DateTime.Now:yyyyMMdd}.txt";
        Console.WriteLine("Logger static constructor çağrıldı. ");
    }

    public static void Log(string message) => Console.WriteLine($"[{DateTime.Now}] {message}");

}

/// <summary>
/// normal class içerisine static class tanımlaya biliriz, static class normal clasın memberı olabilir buna static members denir. 
/// </summary>
public class Counter
{
    public static int Count = 0;
}

///static classın özellikleri özet
///içinde sadece static üyeler olur
///newlenemez yani instance yani örnek oluşturulamaz.
///sealeddir yani miras veremez alamaz
///istance ctor içermez
///static constructur olabilir birdefa çalışır.
///bellekte uygulama boyunca tek kopyadır
/// 
/// static class vs singleton
/// static class -> hiç instance oluşturamaz, sadece class adı ile kullanılır
/// singleton -> instance oluşturabilir ama sadece bir tane garanti eder,
/// eğer helper method yazıyorsan static class kullan
/// eğer tek nesneye ihtiyacın varsa örneğin log, config singleton pattern kullan
/// 
/// ..