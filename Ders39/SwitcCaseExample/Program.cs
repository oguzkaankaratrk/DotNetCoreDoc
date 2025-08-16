//Compare discrete values : Sabit değerlerle karşılaştırma
//Sabit değerlerle switch expression kullanmak
//c# ta bir değişkenin belirli sabit değerlerin hangisine eşit olduğunu kontrol etmek için  switch expression kullanılır. 
//Amacımız tüm olası ihtimalleri kontrol etmek, böylece derleyici bizi uyarır
//default veya _ ile  bilinmeyen durumlara karşı önlem alabiliriz. 

static void main(String[] args)
{
    var manager = new SystemManeger();
    Console.WriteLine("Komutunuzu giriniz, (SystemTest, Start, Stop, Reset");
    string input = Console.ReadLine();


    try
    {
        State result = manager.PerformOperation(input);
        Console.WriteLine("sistem durumu");
        Console.WriteLine(result);
    }
    catch (Exception ex)
    {

        Console.WriteLine($"Hata {ex.Message}");
    }

    Console.WriteLine("kapatmak için bir tuşa basın");
    Console.ReadKey();
}

public class SystemManeger
{

    //string ile karşılaştırma , bunu biz apiden veri aldığımızda kullanırız, çünkü genelden apiden string veri gelir. 
    //kodumuzun amacı, programımızın  durumu string command a göre çalışıp çalışmadığını bulmak. 
    public State PerformOperation(string command) => command switch
    {
        "SystemTest" => RunDiagnostics(),
        "Start" => StartSystem(),
        "Stop" => StopSystem(),
        "Reset" => ResetToReady(),
        _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
    };

    //ReadOnlySpan<char> desteği c#11 ve üzerinde gelen çzelliktir. 
    //ReadOnlySpan<char> : stringin daha hafif bir temsilidir. 
    //bellekte kopya oluşturmadan metin verisi ile işlem yapmamızı sağlar. 
    //Özellikle büyük metinler veya performans hassas uygulamalarda tercih edilir. 
    public State PerformOperation(ReadOnlySpan<char> command) => command switch
    {
        "SystemTest" => RunDiagnostics(),
        "Start" => StartSystem(),
        "Stop" => StopSystem(),
        "Reset" => ResetToReady(),
        _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
    };

    //Enumlar ile karşılaştırma
    public State PerformOperation(Operation command)
    {
        switch (command)
        {
            case Operation.SystemTest:
                return RunDiagnostics();

            case Operation.Start:
                return StartSystem();

            case Operation.Stop:
                return StopSystem();

            case Operation.Reset:
                return ResetToReady();

            default:
                throw new ArgumentException("Invalid enum value for command", nameof(command));


        }
    }

    private State RunDiagnostics()
    {
        return new State { Status = "Diagnostics Complated",
        TimeStamp = DateTime.UtcNow };
    }

    //private State RunDiagnostics() => new State { Status = "Diagnostics Complated" };
    private State StartSystem() => new State { Status = "System Started" };
    private State StopSystem() => new State { Status = "System Stoped" };
    private State ResetToReady() => new State { Status = "System Reseteded" };

}


/// <summary>
/// State = bir sistemi yöneten yazılımda, sistemin o anki durumunu temsil eden bir nesnedir bu örnekte. 
/// yani başlatıldı durdu bilinmeyen bir durum var gibi
/// Developerlar kendi state yapılarını kendileri geliştirebilir, statin genel mantığı budur. Kodu incelersin. 
/// SystemManagement, MayApp.Core, Insdtracture olur bunların genel mantığı aynıdır.
/// </summary>
public class State
{
    public string Status { get; set; }
    public override string ToString() => Status;
    public DateTime TimeStamp { get; set; }
    //yapmak istersen geliştir. 
}

//enum mantığı
//sipariş verildi, hazırlanıyor, kargoya verildi, teslim edildi. biz bu verileri enum ile veri tabanına 1,2,3,4,5 gibi sayılar ile kaydederiz. 
public enum Operation
{
    SystemTest,
    Start,
    Stop,
    Reset
}

//_(Discart pattern) ne işe yarar
//_ herşeyi kapsar. eğer değerlerden koşullardan hiçbiri gerçekleşmezse bu na düşer.  
//_ kodun güvenliğini artırır. 
//Derleyici sizi uyarır. Çünkü derki tüm ihtimalleri değerlendiriyorsunuz. 

//enum switch 
// Belirli değerlerle gelern komutları işler. Tür güvenliği yüksektir. 

//string switch
//mretinsel tabanlı komut sistemleri için uygundur. api gibi

//ReadOnlySpan<char> switch
//Performans amaçlı uygulamalarda kullanılır. string yerine kullanılır. özellikle büyük verilerde. 

//_=> ... (Discard pattern)
//Bilinmeyen durumları kapsar, ve hata kontrolü sağlar. Elinden bişey kaçmaz. 

