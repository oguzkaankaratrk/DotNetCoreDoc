//Access modifier(erişim belirleyicileri)
//Class içindeki nested typeler
//Kullanılabilir erişimler:
//Public, protected, internal, protected internal, private, private protected
//Uyarı: sealed(muhürlü) bir sınıfın içinde protected, protected internal, private protected bir nesteted type tanımlanırsa derleyici CS0628 Uyarılarını verir. 
//Çünkü sealed sınıf miras veremez, protected ve üyelerinin anlamı kalmaz.


//Struct iiçindeki neted tipler
//Public, internal, private
//protected türetilme mantığı structta yoktur.


//Kod kalitesi kuralı CA1034
//CA1034 "Nested types should not be visible" : Nested type ler dışarıya görllünür(public,protected) yapmak çoğu tasarımda hoş karşılanmaz
//////Kural API Tasarımında nested type lar genel(public) yapmamanı önerir
/////Çoğu durumda TOP-LEVEL Type tercih edilir.
///Etkin erişilebilirlik:
///Dış type erişimi, iç tip erişimini sınırlar.
///
internal class Outer { public class Inner { } }

//Inner  public olsada, dıştaki internal içi etkiler.