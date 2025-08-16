///Compile-time type : Derleme zamanı türü anlamına gelmektedir.  
///kodu derleme demek yazılan kaynak kodun makine diline(binary) veya dll, exe gibi yürütülebilir formata dönüştürülme işlemidir.
///Değişkenin kaynak kodunda  belirtilen türüdür. 
///
/// 
/// 
///veri tipi = tür = tip  

string message = "sepete eklendi.";
//string

///Run-time type
///çalışma zamanındaki türüdür.
///


object anotherMessage = "Sepete bidaha eklendi";
//derleme zamanı - compile time ; object
//run time = çalışma zamanı ; string


IEnumerable<char> Char = "asdfghjklş";
//derleme zamanında  : IEnumerable<char>
//run time : string


var person = new { Name = "ALi", Age = 30 };
//derleme zamanında - Compile time ; anonim tip
//çalışma zamanında - runtime : anonim tip
