///Class inheritance : sınıf miras alma
///bir classın, başka bir sınıfın özelliklerini ve davranışlarını devralmasıdır. 
///Object orianted programingin temel özelliğidir. c# oop tabanlıdır.
///--
/// Kalıtım, class adından sonra iki nokta üst üste ( : ) ve temel sınıf (kalıtımı alacağın sınıf ) adını yazılarak alınır.
/// 


internal class Employee
{
    public string Name { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working");
    }
}