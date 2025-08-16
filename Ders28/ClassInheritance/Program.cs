

// Kullanımı
using ClassInheritance;

///Class inheritance : sınıf miras alma
///bir classın, başka bir sınıfın özelliklerini ve davranışlarını devralmasıdır. 
///Object orianted programingin temel özelliğidir. c# oop tabanlıdır.
///--
/// Kalıtım, class adından sonra iki nokta üst üste ( : ) ve temel sınıf (kalıtımı alacağın sınıf ) adını yazılarak alınır.
/// ---
/// Abstract class : soyut sınıf anlamına gelmektedir.
/// başka classların türetilmesi için bir şablon olarak kullanılan ve kendisi doğrudan örneklenemeyen(new) bir sınıftır.
/// sen bu class üzerinde işlem yaparsın inheritance yaparsın ama newleyemezsin
/// neden kullanılır : bir grup sınıfın ortak davranışlarını tanımlamak ve bazı davranışların türetilmiş sınıflar tarafından özelleştirmesini sağlamak için.
/// 



// Kullanımı
Manager manager = new Manager();
manager.Name = "Ali";
manager.Work(); // Çıktı: Ali is working.
manager.Lead(); // Çıktı: Ali is leading.

//dolaylı olarak emloyee ın özelliğini almıştır.
Founder founder = new Founder();
founder.Name = "Kuddusi";
founder.Work(); 
founder.Lead();
founder.Opreation();

//hata veririr abstract newlenemez.
//Shape shape = new Shape();  

Shape cicle = new Circle("Daire", 5);
Shape rectangle = new Rectangle("Dikdörtgen", 4, 6);

cicle.Display(); //Shape : daire
Console.WriteLine($"Area : {cicle.GetArea()}");// Çıktı: Area: 78.54

rectangle.Display(); //Shape : dikdörtgen
Console.WriteLine($"Area : {rectangle.GetArea()}"); // Çıktı: Area: 24