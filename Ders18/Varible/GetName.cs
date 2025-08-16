//bir programlamada değişken yada sabit tanımlarken,
//ya türünü belirlemeniz yada derleyiciye türü çıkarım izin vermek için var anahtar kelimesini kullanmamız garekmektedir.

public class GetName
{

    //Sonuç string döner, biz methoda int gönderiyoruz.
    public string GetNameMethod(int Index)
    {
        if (Index < names.Length)
            return names[Index];
        else
            return string.Empty;
    }

    private string[] names = ["Sally", "Spencer", "Doug"]; //isim dizimiz
}
