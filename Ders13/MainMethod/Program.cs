using System.Text;

///main methodu, c# ın giriş noktasıdır, c# uygulamasını çalıştıran methodtur.
///main methodu program.cs içerisindedir. 
///Program çalıştığında ilk olarak main methodu çalışır. Ve main methodunda sona erer.
///Main methodu static olmalıdır.

/// 
/// 
///Eğer bir programda birden fazla main methodu varsa, derleme srasında hangi main methodun giriş noktası olduğını melirlemeniz gerekir. 
///args dizisi c# programında komut satırından gelen argümanları tutar. 
///Bu, kullanıcıların programı çalıştırırken dışarıdan veri sağlamasına olanak tanır. 
///args, c#ta dizi yani array olarak tanımlanmıştır. 
///kullanıcan şifre, isim soyizim alarak, programın nasıl çalışması gerektirğini yönlendirebiliriz.
/// 

static void Main(string[] args)
{
    Console.WriteLine(args.Length);
}

///Top-Level Statements ile Giriş Noktası : Üst düzey ifadeler olarak türkçeleştirilebilir.
///Bu özellik c#9 üle gelmiştir. 
///Main methoduna gerek kalmadan doğrudan yazmamızı sağlar. 
///return kullanarak değer döndürebilir. 
///Daha küçük projelerde kullanılır. 


//StringBuilder kullanarak çıktı oluşturma
StringBuilder builder = new StringBuilder();
builder.AppendLine("The following arguments are passed");
//StringBuilder : Argumanları girleştirip string oluşturmak için kullanılır.

//Komut satırı argümanlarını döngüyle işleme
foreach (string arg in args)
{
    builder.AppendLine($"Argument={arg}");
}

//Sonuçları konsola yazdırma
Console.WriteLine( builder.ToString() );

//baiarı kodu döndürme
return 0;


/// //GetCommandLineArgs() methodu ile komut satırı argümanları alınabilir. argsın altenatifidir
/// 

//static void Main(string[] args)
//{
 var commandLineArgs = Environment.GetCommandLineArgs();
    Console.WriteLine("GetCommandLineArgs kullanılarak alınan argümanlar:");

    foreach (string arg in commandLineArgs)
    {
        Console.WriteLine(arg);
    }

    Console.WriteLine(args.Length);
//}


///
/// Main dönüş tipleri 
/// void : Hiçbir değer döndürmez
/// int : tamsayı değeri döndürür
/// Task : Asenkron bir işlem dönürür
/// Task<int> : asenkron int döndürür.
/// class ve sruct içerisinde kullanılmalıdır.
/// 


//static void Main(string[] args) { }
//static void Main() { }
//static int Main(string[] args) { return 2; }
//static int Main() { return 2; }
//static async Task Main(string[] args) { }
//static async Task Main() { }
//static async Task<int> Main() { }
//static async Task Main(string[] args) { }
//static async Task<int> Main(string[] args) { }
