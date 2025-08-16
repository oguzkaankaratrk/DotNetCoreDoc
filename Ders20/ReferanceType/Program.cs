

using Microsoft.VisualBasic;
using ReferanceType;

///Referans Tipler
///class, record, delegate, array(system.array sınıfı), interface, string, object, 
///Bir referans tip tanımlandığında, başlangıç değeri null olur. 
///Bu değişkene bir nesne atanana veya new operatörü ile yeni nesne oluşturana kadar geçerlidir.
///------
///Bellek yönetimi ve garbage collection
///Bir nesne oluşturulduğunda(new();) ;
///bellek, heap üzerine yazılır. 
///Değişken (myClass), nesnenin bulunduğu adresi tutar(yani, nesnenin kendisini değil referansını saklar.)
///Garbage collection kullanıklmayan nesneleri siler toplar. 
///---
///referans türler kalıtımı tam anlamıyla destekler.
///virtual ve override işlemi özelleştirilebilir.
///---
///Types of literal values(Sabit değer tipler)
///Bir sabit değer için tür belirtmek istiyorsanız sonunda harf ekleyebilirsiniz
///

float myFloat = 4.56f;
double myDouble = 4.56;//sonuna ek yok, varsayılan olarak double. 



MyClass myClass = new();
myClass.Name("Derviş Nine");
myClass.Name("Hüsamettin Topçu");
myClass.Name("abuzittin");

int[] nums = [1, 2, 3, 4];
int len = nums.Length;

int toplam = 0;

foreach (int num in nums)
{
    toplam += num;
    Console.WriteLine(toplam);
}

int toplam1 = 0;
for (int i = 0; i < nums.Length; i++)
{
    toplam1 += nums[i];
}

Console.WriteLine(toplam1);


string s = "The answer is" + 5.ToString();

//sabitin türünü öğrenme
Type type = 12345.GetType();

int a = 12345;
a.GetType();

///Sayısal sabitlerin türü, son ekler kullanılarak belirtilebilir.(f,d,l gibi);
///son ek belirlenmezse, varsayılan olarak double veya int atanır.