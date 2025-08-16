using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Basket
    {
        private List<Product> _products = new List<Product>();

        public void AddToBasket(Product product)
        {
            _products.Add(product);
            Console.WriteLine($"Ürün Sepete Eklendi {product.Name}");

        }

        public void ShowBasket()
        {
            Console.WriteLine("\nSepetinizdeki Ürünler:");
            foreach (var product in _products)
            {
                Console.WriteLine($"- {product.Name} - ({product.Description})");
            }
        }
    }
}
