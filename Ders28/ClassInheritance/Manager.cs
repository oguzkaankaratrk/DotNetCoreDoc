///Class inheritance : sınıf miras alma
///bir classın, başka bir sınıfın özelliklerini ve davranışlarını devralmasıdır. 
///Object orianted programingin temel özelliğidir. c# oop tabanlıdır.
///--
/// Kalıtım, class adından sonra iki nokta üst üste ( : ) ve temel sınıf (kalıtımı alacağın sınıf ) adını yazılarak alınır.
/// 

//employee bir base sınıftır.
//manager türetilmiş sınıftır
internal class Manager : Employee
{
    public void Lead()
    {
        Console.WriteLine($"{Name} is leading.");
    }
}