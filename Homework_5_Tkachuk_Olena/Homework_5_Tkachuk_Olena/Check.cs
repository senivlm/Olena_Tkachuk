using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Tkachuk_Olena
{
    internal class Check
    {
        public static void ProductInfo(Product product)
        {
            Console.WriteLine("\nInformation about product:\n");
            Console.WriteLine("\tName: {0}\n\tPrice: {1} {2}\n\tWeight: {3} {4}",
                  product.Name, product.Price, product.Currency, product.Weight, product.WeightOfProduct);

        }

        public static void BuyInfo(Dictionary<Product, int> productList)
        {
            Console.WriteLine("\nBasket:\n");
            foreach (var item in productList)
            {
                Console.WriteLine("\t{0} ({1} {2}), {3} {4}, {5} pcs", item.Key.Name, item.Key.Weight, item.Key.WeightOfProduct, item.Key.Price, item.Key.Currency, item.Value);
            }
        }
    }
}
