//partial
//hem classlarda hemde member(method, property, indexer, eventlarda) kullanılan bir özelliktir.
//amaç
//bir class veya member farklı dosya veya katmanlarda yazılabilmesini sağlamak
//geliştirici ve araçlar aynı clasa veya membera katkı sağlasın diye kullanırız

//partial member aslında iki parçadan oluşmaktadır
//declering declaration(bildiren kısım): sadece imza var gövde yok
//implementing decleration(uygulayan kısım): imza + gövde(gerçek kod burada)

//eğer implement eden kısım yok ise, compailer bildire kısmı derlemeden tamamen arabilir (void,privvate,out parametre yoksa)

public partial class MyPartialClass
{
    //sadece bildiren kısım
    partial void OnSamethingHappened(string s);
}

public partial class MyPartialClass
{
    //implement eden kısım
    partial void OnSamethingHappened(string s) =>
        Console.WriteLine($"Something happened: {s}");
}
