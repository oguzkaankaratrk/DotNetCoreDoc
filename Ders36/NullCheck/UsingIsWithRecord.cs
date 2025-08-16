using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    internal record UsingIsWithRecord
    {
        public record Product(string Name, decimal Price);

        object p = new Product("Laptop", 1899);

        public void RecordVoid()
        {
            if(p is Product { Price: > 1500} prod)
            {
                Console.WriteLine($"Pahalı ürün: {prod.Name} - {prod.Price}");  
            }  
            else
            {
                Console.WriteLine("fiyatı düşük ürün");
            }
        }

        //alternatif swich ile record kullanımı
        string GetProductLabel(Product p) => p switch
        {
            { Price: < 5000 } => "Ucuz ürün",
            { Price: >= 5000 and < 15000 } => "orta seviye",
            { Price: >= 15000 } => "Premium",
            null => "Bilinmeyen"

        };
    }
}
