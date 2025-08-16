///c# dilinde struct, class, interface, enum, record yapılarını kullanark kendi özel türlerimizi oluşturabiliriz.
///struct veya recort struct : 
///Küçük depolama alanı(64 byte dan daha az),
///Genellikle değiştirilemez
///Değer temelli türler için uygundur
///
/// Class veya record class :
/// Daha büyük boyutlu, davranış odaklı veya kalıtım(poliformizim) hiyeyarşisine dahil türler için uygundur.
/// Veri saklama 
/// 

///Common Type System
///.Net , tirlerin birbirinden bir kalıtım(inheritance) ilkesini destekler.
///İnheritance :(iki nokta üstüste ile uygulanır.)
///Base TypeBir türün, Başka bir türden türeyebilir.
///base amahtar kelimesi kullanılır
///base i, base classın üyelerine veya methodlarına erişmek veya genişletmek(override) için kullanırız.
///
///object : Tüm türler object ten türetilmiştir. 


//Animal Base type
class Animal
{
    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

//Derived type
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }
}

//Derived type
class Snake : Animal
{
    public void Crawl()
    {
        Console.WriteLine($"{Name} is crawling");
    }
}

//base type
class Vehicle
{
    public string Brand { get; set; }

    //constructor oluşturduk. base için gerekli
    public Vehicle(string brand)
    {
        Brand = brand;
        Console.WriteLine($"Vehicle of brand {brand} is creted.");
    }


    public void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}


//Derived type
class Car : Vehicle
{
    public int NumberOfDoors { get; private set; }

    public Car(string brand, int numberOfDoors) : base(brand)
    {
        NumberOfDoors = numberOfDoors;
        Console.WriteLine($"{brand} car with {numberOfDoors} doors is created.");

    }
    public void Honk()
    {
        Console.WriteLine($"{Brand} car is honking");
    }
}
class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Name = "Fino";
        dog.Eat();
        dog.Bark();


        Snake snake = new Snake();
        snake.Name = "Prina";
        snake.Eat();
        snake.Crawl();

        //Car car = new Car
        //{
        //    Brand = "Toyota",
        //    NumberOfDoors = 8
        //};

        //car.Start();
        //Console.WriteLine($"Brand is {car.Brand}");


        //car.Honk();


        //Console.WriteLine($"Number of Doors: {car.NumberOfDoors}");

        Car car = new Car("Toyota", 6);
        car.Honk();
    }
}