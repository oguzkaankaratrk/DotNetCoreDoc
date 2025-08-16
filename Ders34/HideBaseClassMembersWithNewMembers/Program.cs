//HideBaseClassMembersWithNewMembers : New methodu ile base classı nasıl gizleyeceğiz. 
//Eğer Derived classta, Base classta zaten var olan bir method, field veya property ile aynı isimde bir üye tanımlamak istersen new anahtar kelimesi kullanılır. Bu işleme Hiding(gizleme) denir.

//Neden böyle birşey yapılır
//Bazen Derived classta Base classtaki davranışı tamamen değiştirmek değil, onunla aynı isimde yeni bir versiyon yazmak durumunda kalırız. 
//Ama bu, override değildir, çünkü virtual değildir.
//İşte bu durumda new anahtar kelimesi kullanılır. 


BaseClass A = new BaseClass();
A.DoWork();

DerivedClass B = new DerivedClass();
B.DoWork();

public class BaseClass
{
    public void DoWork() { WorkField++; }
    public int WorkField;
    public int WorkProperty { get { return 0; } }
}

public class DerivedClass : BaseClass
{
    public void DoWork() { WorkField++; } //Aynı isimde bir method
    public int WorkField; //Aynı isimde bir field
    public int WorkProperty { get { return 0; } } //Aynı isimde bir property
}

//PEKİ GİZLEMEYE NEDEN İHTİYAÇ DUYARIZ
//Sen eski bir framework kulannıyorsundur. Ve bu frameworkteki yazılan method property field virtual değildir. Buyüzden gizleyip içeriğini değiştireceksin


public class BaseClassEntityFramework
{
    public void EntityMethod() => Console.WriteLine("Ben yetersiz methodum, bana bişeyler ekle");
}

public class DerivedClassEntityFramework : BaseClassEntityFramework
{
    public void EntityMethod() => Console.WriteLine("Bişeyler yazdım  artık yeterliyim");
}

//İsim çakışmasını yönetmek için kullanırız. Base ve derived classta aynı isimde methodlarımız olması gerekebilir, fakat farklı işler yapacak.

public class Animal
{
    public void MakeSound() => Console.WriteLine("Animal Sound");
}

public class Dog : Animal
{
    public void MakeSound() => Console.WriteLine("Bark");
}

// Not : Eğer sen Polimorfizm istiyorsan Virtual + Override kullancaksın. New kullanmayacaksın hiding kullanmayacaksın.
// Not2 : New yani hiding dahaçok spesifik amaçlarla veya zorunluluktan kullanılır. 

//Örnek olarak bir loglama sistemin var, o method virtual değilse genişletmen gerekiyor ise, hiding kullanabilirsin. 


def topla(a,b):
    retun a+b

sonuc = topla(3,5)
print(sonuc)


public class mat
{
    public int Topla(int a, int b)
    {
        return a + b;


    }
}