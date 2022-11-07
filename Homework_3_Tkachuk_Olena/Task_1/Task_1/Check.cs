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

        public static void CheckDataInformation(List<Product> products)
        {
            foreach(var item in products)
            {
                if (item.GetType() == typeof(Product))
                {
                    Console.WriteLine("Our products:");
                    foreach (Product product in products)
                    {
                        Console.WriteLine("Name: {0}; Price: {1} UAH; Weight: {2} kg",
                            product.Name, product.Price, product.Weight);
                    }
                    Console.WriteLine();
                }
                else if (item.GetType() == typeof(Meat))
                {
                    Console.WriteLine("Our meat:");
                    foreach (Meat i in products)
                    {
                        Console.WriteLine("Name: {0}; Price: {1} UAH; Weight: {2} kg; Category: {3}; Sort: {4}",
                            i.Name, i.Price, i.Weight, i.Category, i.MeatSort);
                    }
                    Console.WriteLine();
                }
                else if (item.GetType() == typeof(Dairy_products))
                {
                    Console.WriteLine("Our dairy products:");
                    foreach (Dairy_products ditem in products)
                    {
                        Console.WriteLine("Name: {0}; Price: {1} UAH; Weight: {2} kg; Expiration: {3} days",
                            ditem.Name, ditem.Price, ditem.Weight, ditem.ProductsExpiration);
                    }
                }
            }

            static void CheckProductsConsoleInformation(int size)
            {

            }
        }        
    }
}
