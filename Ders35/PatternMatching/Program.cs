//Pattern Matching : Bir ifadenin belirli bir özellğe sahip olup olmadığını tesdt ettiğimiz tekniktir. 
//Örneğin bir değişkenin belirli bir tipe sahip olup olmadığını veya belirli bir değeri taşıyıp taşımadığını kontrol ederiz.

//c# ta desen eşleme, ifadeleri test etmek ve eşleştiğimde işlem yapmak için daha sade ve sözlü bir söz dizimidir
//c# sayesinde uzun if else ifyapıları yerine daha kısa ve anlaşılır ifadeler kontroller yapılır

//is ifasdesi, bir ifadeyi test etmek ve eşleşirse bu ifadeden türeyen bir değişken tanımlamak için desen eşlemeyi destekler

//Switch ifadesi, bir ifadenin ilk eşleşen desene göre işlem yapmamızı sağlar

//is ve switch ifadesi çok çeşitli desen türlerini destekler
//sadece tür kontrolü değil, değer kontrolü, karşılaştırmalar, iç içe desenler gibi birçok gelişmiş desenlerde kullanabiliriz. 

//

// Ne işe yarar    : İf  ve switch ifadelerini daha sade daha okunabilir ve güçlü hale getiririz. Karmaşık if-else, switch-case yapılarını sade jale getirir.

//Nerede kullanılır
//Kullanım durumu                               Nassıl yardımcı olur
//object türündeki verilerin işlenmesi          Gerçek türünü kontrol edip güvenle kullanma
//switch yapılarında                            Değer ve koşullara göre dallandırma
//Nesne özelliğini kontrol etme                 yas>18 gibi doğrudan filtreleme
//Tip dönüştürme                                as yerine güvenli is kullanımı
//Koleksiyon ve veri işleme                     Daha esnek koruma sağlar.