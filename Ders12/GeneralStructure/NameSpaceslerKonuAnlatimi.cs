using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region namespaceKonuAnlatimi

///namespace tanımlamak için namespace ismini yazmamız gerekir. 
///namespace içerisine kodları yazarız. 
///kullanım amacı, kod çakışmasını önlemek, kodun organize edilmesini sağlamak, isim çakışmasını önlemek, kodun yönetilebilirliğini artırmaktır.
///bir namespace içerisinde birden fazla class struct delegate, interface olabilir. 
///bir sayfada birde fazla namespace eklene bilir. 
///bir namespace içerisinde namespace tanımlana bilir. 
#endregion
namespace NameSpaceslerKonuAnlatimi
{
    //namespacenin içerisine class tanımlanır.
    class YourClass
    {

    }

    //namespacenin içerisine struct tanımlanır.
    struct YourStruct
    {

    }

    //namespacenin içerisine interface tanımlanır.
    //interfaceler Iharfi ile başlaması önerilir. 
    interface IYourInterface
    {

    }

    //namespacenin içerisine delegate tanımlanır.
    delegate int YourDelegate();

    //namespacenin içerisine enum tanımlanır.
    enum YourEnum { 
    
    }

    //namespacenin içerisine namespace tanımlanır.
    //namespace içerisine namespace tanımlanmasına nested namespace denir.
    namespace YourNamespace
    {

    }

}


