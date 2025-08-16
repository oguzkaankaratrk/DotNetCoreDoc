///Nesne oluşturma - Creating Object
///class ve object birbirinden farklı kavramlardır. 
///Class : bir nesnenin türünü tanımlar. ama nesne değildiri.
///object : Bir class a dayalı somut bir varlıktır. bir classın instance(örneğini) olarak adlandırılabilir. 
///----
///Nesne nasıl oluşturulur
///new anahtar kelimesinini kullanarak oluşturulur. 
///,
///

internal class Customer
{
    public Customer()
    {
        //customer ile alakalı kodları yazdık.
    }
    public string Name;

    public void Bizplay()
    {
        Console.WriteLine($"Müşteri: {Name}");
    }   
}