using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaces
{
    internal class LoginModel
    {
    }
}


//Kendi namespacelerimizi tanımlaya biliriz. Büyük projelerde kodun düzenini ve kapsamını kontrol eder.
namespace benimNameSpace
{
   public class Mushab
    {
        

        public void benimAdim(string name)
        {
            Console.WriteLine("sanane kardeşim istediğim methodu yazarım.");
            Console.WriteLine("mushab");

            Console.WriteLine(name);

            return;
        }

    }

}