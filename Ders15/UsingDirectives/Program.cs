using ForLoop;
using System.Text; //kullanacapımız kodun namespacesini yazarız
using Hashing;

//Biz bir classta bir kod yazdık. Using ile o kodun namespacesini kullanacağımız ssayfaya  ederiz
//daha önce farklı sayfada yazdığımız bir kodu, bir diğer sayfada çalıştırmak istiyorsak using kullanılır.


StringBuilder builder = new StringBuilder();

ForClass forClass = new ForClass();
forClass.ForeachKonu();

PasswordHasher passwordHasher = new();
//passwordHasher.AddPassword("MushabınŞidfresin2345678");
