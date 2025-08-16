//1.Record
//Recordlarla genellikle veri taşınır
//Veri odaklı nesneler oluşturmak için kullanılmaktadır
//İmmutable(değiştirilemez) veri tipleri oluşturmada yaygın olarak kullanılır.
//Record, class gibi referans tiptir ama veri odaklı işlevsellik sağlar.
//Record kelimesi, otomatik olarak property tanımlamar, value equality(değer eşitliği), deconstruct ve immutable özellikler gibi ek kolaylık sağlar.

using System.Security.Cryptography.X509Certificates;

void Main(string[] args)
{
    //3. Immutabilibty(değiştirilemezlik)
    //recordlarda init accessor kullanılır

    var p = new Person("Ali", "Kaya");
    p.FirstName = "mehemt"; //Derleme hatası, init only

    //doğrudan değiştiremezsin ama with ile kopyasını(nondestructive mutation) yapılabilir

    var p2 = p with { FirstName = "mehemt" };


    //4. Value Equality(Değer eşitliği)
    //Recordlar, == ve Equals() metodunu propertylerine göre karşolaştırır
    var p1 = new Person("Ali", "Kaya");
    var p2 = new Person("Ali", "Kaya");

    Console.WriteLine(p1 == p2);//true

    //5. record class ve record struct
    //record class : Referans tiptir(class gibi davranır)
    // record struct : Değer tiptir(struct gibi davranır.)
}

//2. Positional syntax, record tanımda parametlereleri  doğrudan tanımlayarak propertyleri otomatik oluşturur
//bu aslında aşağıdaki uzun yazımın kısa yoludur.
//Record kelimesi, otomatik olarak property tanımlamar
public record Person(string FirstName, string LastName);
//Person türünde iki nesneyi değerine göre karşılaştırır(Class refaransına göre karşılaştırır)


//public record Person(string FirstName, string LastName);
//aşağıdaki ile aynıdır.
public record Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}


//Record veri odaklı nesneler için idealdir
//kısa temiz kod yazarsın
//Değer bazlı eşitlik sağlar
//with ifadesi ile kolay kopyalanabiilir
//Immutable(değiştiriilemez) propertyler otomatik olarak gelir.