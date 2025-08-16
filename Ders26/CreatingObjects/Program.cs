///Nesne oluşturma - Creating Object
///class ve object birbirinden farklı kavramlardır. 
///Class : bir nesnenin türünü tanımlar. ama nesne değildiri.Özelliklerini tanımlıyoruz.
///object : Bir class a dayalı somut bir varlıktır. bir classın instance(örneğini) olarak adlandırılabilir. 
///----
///Nesne nasıl oluşturulur
///new anahtar kelimesinini kullanarak oluşturulur. 
///,
///

Customer customerObject = new Customer(); //kopyası, nesnesi, instance sini aldık. işlem yapmak için. 
Customer customer = new();
//Customer classı bir referans tiptir.
//customerObject ise Customer classından türetilmiş bir nesneye referanstır. 
//new dediğinde bellekte bir yer ayırmış bulunmaktasın. bellekte bir isimle refaransı dödürülür. bunada nesne referansı denir. 

customerObject.Name = "Nazım Hikmet Ran";

customerObject.Bizplay();


////hatalı kullanım.
//Customer customer3;

//customer3.Name = "mehmet"; //bu hata-nın ismi öalışma zamanı hatası. 
////yani class oluşturduktan sonra, nesne oluşturup işlep yapın.

Customer customerObject2 = customerObject;

customerObject2.Name = "Veli";
Console.WriteLine(customerObject2);//veli


