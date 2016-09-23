using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOpenClosedPrinciple
{
    class ProductConsole
    {
        public static void Main()
        {
            var product1 = new StandardProduct(4.52m /*ProductType.Standard*/);
            var product2 = new FeaturedProducts(3.99m /*ProductType.Featured*/);
            var product3 = new FeaturedProducts(609m /*ProductType.Featured*/);
            var product4 = new StandardProduct(1.33m /*ProductType.Standard*/);

            var products = new List<Product>();

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            foreach (Product product in products)
            {
                product.Render();
            }


            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();
        
        }
    }
}
