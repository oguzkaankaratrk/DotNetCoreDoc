//bu alanı veri tabanı olarak düşün.

//Aşağıdaki fiyatların minimum ve maximum değerlerini yazan programı dotnette yazınız. 
int price1 = 25;
int price2 = 3456;
int price3 = 4526374;
int price4 = 98;
int price5 = 1;

decimal de;


//Bir sayısal veritipinin(int float) en fazla veya en az kaç değer aldığını öğrenmek istiyorsak
//MinValue Veya MaxValue kullanılır.
int maxDeger = int.MaxValue;
int minDeger = int.MinValue;



//string içerisine dinamik veri eklemek için,
//tırnağın dışına dolarkoy, dinamik veri olarak ne yazacaksan tırnağın içerisine süslü parantezde yaz.
//bir veri string ise(düz yazı) ise kesinlikle tırnak içerisinde olmalıdır.
Console.WriteLine($"birinci fiyat : {price1}");

//statik veri
Console.WriteLine("birinci fiyat : price1");

//max min değeri bulma(filtremlemede kullanılabilir.)
Console.WriteLine($"minimum fiyat : {minDeger} Maximum fiyat :{maxDeger}");

