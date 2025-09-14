///Recordslar 
///Immutable(değiştirilemezdir)
///,
///classlar refars tiptir
///record classlar değer tiplidir.
///recordlar default olarak value equality sağlar yani tüm propertyler eşitse eşittir.
/// recordlar recordlardan miras alabilir.
/// record class -> init only property oluşturur, immutable yaklaşım
/// record struct -> read - write property oluşturur, mutable yaklaşım.
/// 
/// class, referans tiptir, immutable desteği manuel olarak yazılır, whith expression kullanılmaz, to sitring kullanabilirsin, classlardan miras alır, oop  amacı ile kullanılır
/// struct, Value (alan bazlı), immuteble desteğini manu olarak yazabilirsin, tostring kullanabiilrisin, with expression kullanılmaz, struct sealed, performans küçük tipler
/// record class, Value (property bazlı), immutable primary ctor ile kolay, with desteği vardır, tostring property ad değer, recordlar ile miras alınır, immutable  veri nesneler ve DTO amacı ile kullanılır
/// Record struct, Value (property bazlı), immutable desteği primary ctor ile kolay, with kullanılır, to string property ad değer, miras recurd struct ile, kullanum amacı value type ve value equlity
/// 


static void Main(string[] args)
{
    Person person = new Person();
    person.Name = "Ali";
    person.Lastname = "Yılmaz";
    Console.WriteLine(person);

    person.Name = "mehmet"; //hata gözükmez ama değişmez.
}

public record Person
{
    public string Name { get; set; }
    public string Lastname { get; set; }
}



public struct Point
{

}



