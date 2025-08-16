//Null Check : Pattern Matchingin en yaygın tekniklerindendir. Değerin null olup olmadığını kontrol eder.

int status = 200; //200 başarılı

if (status is int number)
{
  
    Console.WriteLine($"belirtilen nullable int 'status' değişkeni şu değeri taşıyor {number}");
    //sayfa yönlendirmesi yap kodları buraya yaz. ödeme istedin 200 döndü. başarılı. sayfa yönlerdirmesi yapıldı. order sayfasına at. 
}
else
{
    Console.WriteLine($"belirtilen nullable intn 'maybe' herhangi bir değer taşıyor");
}

string? message = "mesajımız";

if (message is not null)
{
    Console.WriteLine(message);
}

if (message is null)
{
    Console.WriteLine("Mesajınız boştur");
}
if (message != null)
{
    Console.WriteLine(message);
}

if (message == null)
{
Console.WriteLine("Mesajınız boştur"); 
}

//Eki yol               //Yeni yol
//if (message != null) ;  if (message is not null) ;
//if (message == null) ;  if (message is null) ;
//if (message is int) ;   if (message is int number) ;
//Sadece kontrol yapacaksan bunu kullan if (message is int) ; 404 mü. 404 ama 404 ile işim kalmadı sadece kontrol.
//Kontrol edip datayı kullanacaksan if (message is int number) ; bunu kullan. //404 kontrolü yapıldı ama benim 404 ile işim bitmedi. 