//new kullanmadan nesnenin örneğini object initializer ile değiştirmeyi sağlama.

public class ObjectInitializerWithoutNew
{
    public class Address
    {
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
    }

    public class Person
    {
        public string Name { get; set; } = "";
        public Address HomeAddress { get; set; } = new(); // Property with setter
        //sadece get yapsan bile bu yöntem ileveriyi güncelleyebilirsin.
        //public Address HomeAddress { get; } = new(); // Property with setter
    }

    public static void Examples()
    {
        //Using object initializer without 'new' keyword
        //tihis midifies the existing address instance created in the constructor
        var person = new Person
        {
            Name = "Musab",
            HomeAddress = { Street = "Elmadağ", City = "istanbul", State = "şişli" }
        };

        //using object initializer with 'new' keyword
        //this crested a  comletely new address instance
        var person2 = new Person
        {
            Name = "muhammet",
            HomeAddress = new Address{ Street = "Elmadağ", City = "istanbul", State = "şişli" }
        };


    }
}

//Bir class yaptık bunu jant kalıbı olark düşün
//Kalıbın içerisine eritilmiş demir döktük oluşan demir jant instance dir.


//new                                                       without new
//yeni address instance oluşturur, eskisini tamamen değiştirir. yeni address instancenin properylerini günceller
//sadece get(read only) yaparsan veriyi asla değiştiremezsin. propertiyi güncelleye bilirsin
//bellek yönetiminde sesne oluşur eskisi çöpe gire.         eski nesne korynyr refarans aynı kalır
//kullanım amacı eskiyi değiştirmek.                        kullanım amacı güncellemek.