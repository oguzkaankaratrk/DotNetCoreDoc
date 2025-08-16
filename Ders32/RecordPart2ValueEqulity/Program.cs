
using RecordPart2ValueEqulity;

///C# gibi modern programlama dillerinde, bellek yönetimi iki temel yöntem ile yapılmaktadır. 
///Bunlar stack ve heap tir. 
///Bu iki yapı, programın verileri nasıl saklandığını ve işlendiğini anlamak için kullanılır.
///------
///Stack : Kısa ömürlü ve sabit boyutlu verilerin saklandığı, hızlı ve verimli bellek bölgesidir. 
///Genellikle bir method çağırıldığında kullanılan lokal değişkenler yer alır. 
///Özellikleri
///1. Last in firs out (Son giren ilk çıkar.)prensine dayanır. 
///verilerin erişimi ve işlem yapısı çok hızlıdır. 
///int float bool, struct gibi değer türleri burada saklanır.
///Boyutu sınırlıdır, genellikle sistem tarafından belirlenir.
///Büyük boyutlu ve uzun ömürlü  işlemler için uygun değildir. 
///Bir method çağırıldığında ilgili değişkenler stacke eklenir. methotla işin bitince otomatik silinir.
///
void StackExample()
{
    int a = 10; // 'a' stack'te saklanır.
    int b = 20; // 'b' de stack'te saklanır.
    int c = a + b; // 'c' de stack'te saklanır.
} // Metot sona erdiğinde, 'a', 'b', ve 'c' stack'ten otomatik olarak silinir.

///Heap : Dinamik olarak ayrılan büyük boyutlu veya uzun ömürlü verilerin saklandığı yerdir. 
///Runtime da otomatik olarak oluşur.
///new anahtar kelimesi kullanarak bellekte yer alır.
///stacke göre yavaştır
///Bunun nedeni heapin bellek tahsisi ve serbest bırakımı için ekstra yönetim gereklidir
///nesneleri uzun süreli saklamak için kullanılır. 
///objjeckt, class veya referans türler burada saklanır.
///Garbage collector tarafından temizlenir. 
///

void HeapExample()
{
    // 'person' referansı stack'te, ancak gerçek nesne (Name, Age) heap'te saklanır.
    var person = new Person { Name = "Ali", Age = 30 };
} // Metot sona erse bile, person heap'teki belleği işgal etmeye devam eder.




///Rekordların kullanım alanları
///1. Value Equlity - Değer Eşitliği
///Eğer nesnlerin karşılaştırmasında, referans yerine değerleri üzerinden eşitliği
///kontrol etmek istiyorsanız rekord tüpü kullanabilirsiniz
///Normal Classlarda, nesne eşitliği referans eşitliği ile karşılaştırılır. 
///Yani classlarda referas eşitliği kullanılır
#region Açıklaması
///Mealen Ek açıklama Star *****
///Referans eşitliği  iki nesnenin aynı bellekt adreinde olup olmadığını karşılaştırır.
///eğer iki nesne aynı adresi işaret ediyorsa eşit kabul edilir
///nesnelerin içerikleri aynı olsa bile, referansları farklı ile eşit sayılmaz.
///

public class Man
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        //Aynı özelliğe sahip iki nesne oluşturduk.
        Man man = new Man { Name = "Alperper tunga", Age = 30 };
        Man man1 = new Man { Name = "Alperper tunga", Age = 30 };

        //Eşitlik kontrolü
        Console.WriteLine(man == man1); //false

        //refaransı kopyalayalım
        Man man2 = man;
        Console.WriteLine(man2 == man); //true

        ///açıklama
        ///1. man ve man 1 aynı özelliklere sahip(alpertunga 30 yaşında) olsa da, 
        ///farklı bellek adreslerinde saklanır. stackte man ve man 1 adreslerine karşılık gelen iki adres değeri üretilir ancak biz heape man ve man1 üzerinde erşip işlemler gerçekleştiririz.
        ///2. man 2, manin referansını kopyaladı. bu nedenle her iki değişkende aynı bellek adresini işarek eder ve referans eşitliği olur.
        ///


        ///yani, iki nesnenin bellek edresleri aynı ise eşit olarak kabul edilir. 
        ///Ancak recor türlerinde değer eşitliği kullanılır.
        ///İki record nenenin tüm özellik değerleri aynı ise bu iki nesne eşit olarak kabul edilir.
        ///.
        ///2. 

        Person person1 = new Person();

        

        person1.Name = "Yusuf ziya";
        //Person = heapte
        //person 1 = stacte biz heape person1 üzerinden erişeceğiz.
    }
} 
#endregion
