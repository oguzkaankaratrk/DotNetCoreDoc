//Object Initiallizer
//Normalde bir nesne oluştururken constructor kullanırız.

//Constructor ile kullanımı
//Person sınıfını tanımla yorum satırını açtığında hata alma.
using ObjectInitializer;

//Parametreli constructoru çalıştırma
var person = new Person("Ali", "Yılmaz", 23);
person.PrintInfo();

//Object Initializer
//Parametreli consructor
var person1 = new Person
{
    FirstName = "ALi",
    LastName = "Yılmaz",
    Age = 1,
};
person1.PrintInfo();


//Constructor ile object ınitializerin birlikte kullanımı
var person2 = new Person("Ali", "Yılmaz", 40)
{
    Age = 1,
};

var person3 = new List<Person>
{
    new Person("Ali","Yılmaz",34),
    new Person("Ali","Yılmaz",34),
    new Person("Ali","Yılmaz",34),
    new Person("Ali","Yılmaz",34),
    new Person("Ali","Yılmaz",34),
};

//Ama object İnitializer sayesinde parametresiz Constructor + property atamaları ile nesneyi declaretif bir şekilde yapabliriz.

//Nested Initializer
var c = new Customer
        {
            Name = "Ahmet muhip dıranas",
            Address = new Address { City = "sinop", Street = "Çukurbağ" }
        };

//Anonymous Type
var anonipType = new { FirtName = "Ali", LastName = "Yılmaz" };

//CollectionInitializer
var list = new List<Person>
{
    new Person {FirstName = "Ali" , LastName = "Yılmaz"},
    new Person {FirstName = "Mehmet" , LastName = "Kaya"}
};

//Kısacası
//Constructor -> başlatmada parametre zorunlu kısa ama daha az esnek.
//Object Initializer -> parametresiz çalıştırabiliriz., propertleri gtek tek set ederiz faha okunulabilir.
//Birlikte kullanım ->Birlikte kullanınca obvverride edebilir verileri geğişebilirsin.
//Koleksiyonlar ile -> Liste işlemlerinde çok pratiktir.