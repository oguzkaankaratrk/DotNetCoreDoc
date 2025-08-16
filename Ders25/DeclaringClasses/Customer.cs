using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringClasses
{
    //public : heryerden erişilebilir
    //internal : yalnızca bu projeden erişebiliriz.
    //protected : internal veya public classın içerisinde kullanabilirsin. doğrudan erişemezsin, o classı miras alarak erişebilirsin.
    //private : internal veya public classın içerisinde kullanabilirsin. sadece o classın içerisinden erişilebilir.

    //classın {fields, properties, methods, events }  süslü parantezi içerisinde bunlar kullanılır.
    internal class Customer
    {
        //field - alan
        private string name = "Vildan karabacak";

        //property
        public string Name { get; set; }

        //method
        public void DisplayCustomer()
        {
            Console.WriteLine($"Müşteri Adı: {name}");
        }


        private class ButceHesapla
        {
            //bütçe hesaplama işlemleri
        }

        protected class HesapBilgisi
        {

        }
    }


}
