//Partial
//Parçalı anlamına gelmektedir
//Partial classlar c# dilinde  kullanılan bir özelliktir.
//Bir classın, structun, interface nin veya methodun tanımının birden fazla dosyaya bölünmesidir. 
//partial anahtar kelimesi, bir class ın(veya method/interface/struct gibi yapıların) birden fazla dosyalarda tanımlanmasıdır.

//ne işe yarar 
//Büyük class ların birden fazla dosyada modüler şekilde yazmasını sağlamaktadır.
//Otomatik üretilen kodları(örneğin,designer dosyalar), elle yazılan dosyalardan ayrılmasını sağlar.
//aunı class ı bozmadan yeni özellikler eklemene olanak tanır. 

// ne zaman kullanılır
// kodu bölmek istiyorsan, sınıfın çok büyükse, anlamlı parçalar halinde bölebilirsin
//Otomatik oluşturulan kod varsa(toollar tarafından oluşturulan(designer.cs,.g.cs) elle yazılanlardan ayrılır.)
//ekip çalış,ması, farklı geliştiriciler aynı sınıfın farklı kısımları üzerinde çalışabilirler.
//test uzmanları test yaparken
//eklentiler eklerkende kullanılır.


//bunu nasıl kullanıcaz
//partıal class tanımlamak için clasın başınapartial eklemen yeterli

public partial class PartialDenemeClass
{

}