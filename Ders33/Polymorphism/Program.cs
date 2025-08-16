//Polymorphism (Kalıtım) : 
//Derived class : Bir alt sınıf. 
//Base Class   : Üst sınıf 
//Derived(alt) class, base(üst) classtan miras alındığında [derived : base], derived class base classın tüm üyelerini(property, method, entity..) içerir. 

//Böylece alt sınıf nesneleri, üst sınıfın bir nesnesi imiş gibi davranır. 

//Bu, Nesne yönelimli programlamada(OOP) Temel özelliğidir. 

//Cocuk : Ebevey



//Virtual methodlar (Sanal Methodlar Ve Özellikler)
//Üst sınıfta virtual olarak işaretlenen bir method/property, alt sınıflardan ovveride edilerek yeniden yazılabilir.
//Virtual olarak işaretlediğin alt sınıfın davranışlarını özelleştirebilmen anlamına gelmektedir.

//Derived (Alt) sınıfın 3 özelliği vardır.
 


public class BaseClass
{
    public virtual void DoWork() { } //override edilebilir method
    public virtual int WorkProperty => 0; //Override edilebilir Property
}

//1.Override etmek
//Derived class virtual üyeyi override ederek yeni bir davranış tanımlaya bilirsin.
public class DrivedClass : BaseClass
{
    public override void DoWork()
    {
        Console.WriteLine("Yeni method,(Dowork ün içini değiştirdin");
    }

    public override int WorkProperty => 42;
}

//2. Olduğu gibi kullanmak
//Derived classı olduğu gibi kullanabilirsin. Override etmeden kullana bilirsin. Üst sınıfın methodlarını aynen kullanmaya devam eder. 

public class DrivedClass2 : BaseClass
{

}




//3. Yeni bir method tanımlamak(Hiding)
//derived class aynı isimle yeni bir method tanımlar ama override etmez. Bu durumda new anahtar kelimesi kullanılır. Ancak virtual çağrıları geçersiz kılar.
//Main methodunun içine bak

class Program
{



    DrivedClass B = new DrivedClass();

}

//Yalnıca methodlar, properyler, event, indexerlar virtual olabilir. Fieldlar virtual olamaz.


    B.DoWork(); //Derived içindeki yeni methodu çağırır

    BaseClass A = B; //Polymorphisim kullanımı
    A.DoWork(); //Yide DrivedClass içindeki method çağırır   