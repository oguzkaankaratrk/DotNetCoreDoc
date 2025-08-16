//bir programlamada değişken yada sabit tanımlarken,
//ya türünü belirlemeniz yada derleyiciye türü çıkarım izin vermek için var anahtar kelimesini kullanmamız garekmektedir.

float temprerature;//ondalıklı sayı
string name;
GetName getNames = new GetName(); //kullanıcı tanımlı, daha önceden tanımladığımız değişken class
var sonuc = getNames.GetNameMethod(3);

Console.WriteLine(sonuc);

//Tanım ve Başlatma
char firstLetter = 'C'; //Bir karakter saklar
var limit = 3; // Derleyici tarafından çıkarılan tam sayı //int
int[] source = [1, 2, 3, 4, 5, 6]; //Tamsayı dizisi
var query = from item in source //link sorgusu (Türü otomatik belirler)
            where item <= limit
            select item;


///Bir değişken tanımlanırken:
///Aynı isimde  yeni bir tür tanımlayamazsın.
///tanımladığın türe uyumlu olmayan bir değer atayamazsın.
///

int number = 5;
//number = true;

number = 345678;


//float number = 2.34;

//Tür dönüşümleri (Casting ve Type Conversion)

//veri kaybına neden olmayan dönüşümler
//bru tür dönüşümleri derleyici tarafından otomatik olarak gerçekleşir.

int myInt = 42;

double myDouble = myInt;//otomatik olarak dönüşüm veri kaybı yok


//veri kaybına neden olavilecek dönüşümler
//Bu tür dönüşümler kaynak kodda açık bir şekilde belirtilir. (casting)

double dobleValue = 42.99;
int intValue = (int)myDouble; //// Cast yapılır, ondalık kısım kaybolur.