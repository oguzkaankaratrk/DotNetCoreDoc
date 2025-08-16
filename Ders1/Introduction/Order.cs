using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction //0smanlı arşivi
{
    public class Order
    {
        public int Id { get; set; } = 123456;
        public string Name { get; set; } = "Künefe";
    }
}

namespace payment //selçuklu arşivi
{
    public class GarantiBankKartBilgileri
    {
        public int KartNumarası { get; set; }
        public string NameSurname { get; set; }

    }
}

//öğrenci bilgileri
