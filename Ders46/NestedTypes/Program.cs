//Nested types(İç içe)
//C# ta çok büyük sınıfları düzenlemek, ayrıntıları kapsüllemek ve implementasyonları tedaylarını 
//saklamak için çok kullanışlı bir methodtur.
//Bir class, interface veya struct içinde tanımlanan herhangi bir tipe nested type denir. 

//nested class
//Bu örnekte Nested, container içinde tanımlı bir classtır.
public class Container
{
    class Nested()
    {

    }

    //nested type
    //varsayılan private
    private class Mushab
    {

    }

    //Dış tip class struct yada interface olsa bile varsayılan erişim belirteci privatedir.
}