//Pattern matching
//Değişkenin  türünü kontrol ederiz, Değerlerini karşılaştırız, özelliklerini test ederiz, Veya başka koşulları varsa kontrol ederiz.
//bu yapı sayasinde is, switch, switch expession gibi ifadeler daha esnek kullanılır. 

//C# Ta desteklenen pattern türleri özeti
//Decleration pattern       is  Type x gibi tür eşleşirse değişkene atar
//Type pattern              sadece türü kontrol eder x is string
//Constant pattern          Belli sabit değere eşleşir, x is 5, d is "admin"
//Relational pattern        Karşılaştırılmalı: X  is > 10, x is <= 100
//logical pattern           and, or, not ile  birden fazla koşul  kontrolü yapılır. x is > 10 and < 100
//Var pattern               Her zaman  eşleşir, değeri değişkene atar
//Discard pattern(_)        Herşeyi kabul eder -> "diğer tüm  koşullar " anlamına gelir
//List pattern(c#11)        Dizi/listelerindeki belirli sayıdaki elemanları eşleştirir[1,2,3,4,5,...]


//c# 9 ve sonrası patternları mantıksal operatörlerele birleştirebiliriz. 
//and, iki koşul doğru ise
//or, en az biri doğru ise
//not, Koşul yanlış ise

//Recursive Patterns 
//Bazı patternlerin iç içe kullanılmasıdır. 


//Declaration pattern: is  Type x gibi tür eşleşirse değişkene atar
object obj = "hello";
if(obj is string s) //obj  hem string türünde hemde nul değilse
{
    Console.WriteLine($"stirng uzunluğu{s.Length}");
}
//obj değişkeni string değilse s adinda bir değişkene atar.



//Type pattern: sadece türü kontrol eder x is string
object x = 42;
if(x is int)
{
    Console.WriteLine("bu bir int");
}
//değeri kullanmazsın sadece türünü kontrol edersin



////Constant pattern: Belli sabit değere eşleşir, x is 5, d is "admin"
string role = "Admin"; //sabit
if(role == "Admin")
{
    Console.WriteLine("Abi sen yetkili birine benziiyorsun");
}


////Relational pattern: Karşılaştırılmalı: X  is > 10, x is <= 100
int age = 25;
if(age is  > 18 and < 65)
{
    Console.WriteLine("Çalışma çağğındaki kişi");
}


//logical pattern: and, or, not ile  birden fazla koşul  kontrolü yapılır. x is > 10 and < 100
int score = 85;
if (score is >= 80 and <= 100)
{
    Console.WriteLine("Başarılı!");
}

if (score is < 50 or > 100)
{
    Console.WriteLine("Geçersiz not.");
}

if (score is not < 60)
{
    Console.WriteLine("Geçti!");
}


//Property pattern:	Bir nesnenin içindeki property'lere göre eşleşme
var person = new { Name = "Ali", Age = 30 };

if (person is { Age: > 18 })//Nesnenin içindeki propertiyi doğrudan kontrol ederiz.
{
    Console.WriteLine($"{person.Name} yetişkin.");
}

//Positional pattern	Deconstruct edilen (parçalanan) tuple veya record türleri için
//RECORD VEYA Tuple gibi yapıları eşleştirir
public record Point(int X, int Y);

var p = new Point(0, 5);

if (p is (0, var y))
{
    Console.WriteLine($"Y ekseninde: {y}");
}

////Var pattern Her zaman  eşleşir, değeri değişkene atar
Object objt = "Dotnet Core";

if(objt is var something) //ne gelirse gelsin eşleşir değeri somethinge atar,  genelde feedback gibi kullanılır
{
    Console.WriteLine($"Değer {something}");
}

////Discard pattern(_)        Herşeyi kabul eder -> "diğer tüm  koşullar " anlamına gelir
string input = "Test";

switch (input)
{
    case "Start":
        Console.WriteLine("Başlatılıyor...");
        break;
    case _:
        Console.WriteLine("Bilinmeyen komut.");
        break;
}

//List pattern(c#11)        Dizi/listelerindeki belirli sayıdaki elemanları eşleştirir[1,2,3,4,5,...]
int[] numbers = { 1, 2, 3 };

if (numbers is [1, 2, 3])
{
    Console.WriteLine("Tam eşleşme: [1, 2, 3]");
}

if (numbers is [1, ..])
{
    Console.WriteLine("1 ile başlıyor.");
}
