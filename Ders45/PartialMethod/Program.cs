//partial method un imlement edilmesi zorunlu değildir. yalnızca koşullar sağlıyorsa
//void döner
//genelde private kullanılır
//out parametresi yok
//virtual, override, sealded, new, extern kullanılmaz



//kurallara uyan, implemente edilmesi zorunlu olmayan partial method
public partial class Person
{
    //sadece imza, private void, erişim belirteci yok.
    partial void OnNameCahnged(string newName);

    private string _name;

    private string Name
    {
        get => _name;
        set
        {
            _name = value;

            OnNameCahnged(value);
        }
    }
}

//imlemente etmek zorunlu değildir.
public partial class Person
{
    //implemente et
    partial void OnNameCahnged(string newName)
    {
        Console.WriteLine($"name chaged to: {newName}");
    }
}

//eğer ikinci kısımdaki implementasyonu silersen
//OnNameCahnged ve tüm çağrıları derlemede tamamen yok edilir.
//kod yine çalışır hiçbir hata vermez.


//bunlardan biri ihlal edilirse(ör public partial string GetName()), ozaman implemente edilmek zorundadır.


//Kuralları ihlal eden, implemente edilmesi zorunlu olan partial method.
public partial class Employee
{
    //kuralları ihlal ediyor
    //__public var, string dönüyor
    public partial string GetName();
}

public partial class Employee
{
    private string _name = "mushab";

    //bu imlemantasyon yazılmak zorunludur.
    //aksi halde derleyici hata verir. 
    public partial string GetName()
    {
        return _name;
    }
}