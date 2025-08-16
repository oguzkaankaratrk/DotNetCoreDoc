using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SwitcCaseExample
{
    /// <summary>
    /// Bir değişkenin değerine, veya bir enumun veya ... değere göre farklı bir kod bloğunun çalışmasıdır
    /// İf-else ye alternatiftir. ama çok sayıda sabit değer kontrolü için kullanılır. 
    /// Yani bir sabit değer varsa bunu çalıştur, başka bir sabit değer varsa başka bir kod bloğunu çalıştır demek. 
    /// 
    ///Özellikle enum string int gibi değerlerle çalışırken kullanrıız
    ///
    /// 
    /// </summary>
    public class SwitchCase
    {
        public Report WhichDays(Operation day = Operation.carşamba)
        {
            switch (day)
            {
                case Operation.pazatesi:
                    return new Report { Id = new Guid(), City = "Bolu", Country = "Bolu cumhuriyeti", Date = DateTime.Now, Departman = "Tourism", Name = "Ticket officer" };

                case Operation.Salı:
                    return new Report { Id = new Guid(), City = "Bolu", Country = "Bolu cumhuriyeti", Date = DateTime.Now, Departman = "Tourism", Name = "Ticket officer" };

                case Operation.carşamba:
                    return new Report { Id = new Guid(), City = "Bolu", Country = "Bolu cumhuriyeti", Date = DateTime.Now, Departman = "Tourism",Name ="Ticket officer" };
                
                case Operation.perşembe:
                    return new Report { Id = new Guid(), City = "Bolu", Country = "Bolu cumhuriyeti", Date = DateTime.Now, Departman = "Tourism", Name = "Ticket officer" };

                case Operation.cuma:
                    return new Report { Id = new Guid(), City = "Bolu", Country = "Bolu cumhuriyeti", Date = DateTime.Now, Departman = "Tourism", Name = "Ticket officer" };

                default:
                    return new Report { Id = new Guid(), City = "Bolu", Country = "Bolu cumhuriyeti", Date = DateTime.Now, Departman = "Tourism", Name = "Ticket officer" };

            }


        }
        public enum Operation
        {
            pazatesi = 1,
            Salı = 2,
            carşamba = 3,
            perşembe = 4,
            cuma = 5
        }
    }

    public class Report
    {
        public Guid Id { get; set; } = new Guid();  
        public string Name { get; set; } = "Satış raporları";
        public string Description { get; set; } = "Turizme verilerine ait bilgilerinize sadece erişim vardır.";
        public string Departman { get; set; } = "Tourism";
        public DateTime Date { get; set; } = DateTime.Now;
        public string Country { get; set; } = "Turkiye";
        public string City { get; set; } = "Trabzon";
    }
}
