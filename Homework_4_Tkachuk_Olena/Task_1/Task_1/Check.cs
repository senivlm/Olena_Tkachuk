using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Check
    {
        public static void ProductInfo(Product product)
        {
            Console.WriteLine("\nInformation about product:\n");
            Console.WriteLine("\tName: {0}\n\tPrice: {1} UAH\n\tWeight: {2} kg",
                  product.Name, product.Price, product.Weight);

        }

        public static void BuyInfo(Dictionary<Product, int> productList)
        {
            Console.WriteLine("\nPurchase information:\n");
            foreach (var item in productList)
            {
                Console.WriteLine("\t{0} {1} pcs", item.Key.Name, item.Value);
            }
        }
    }
}
