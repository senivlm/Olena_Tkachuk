using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Tkachuk_Olena
{
    internal class Check
    {
        public static void ProductInfo(Product product)
        {
            Console.WriteLine("\nInformation about product:\n"); 
            Console.WriteLine("\tName: {0}\n\tPrice: {1} UAH\n\tWeight: {2} kg", 
                  product.Name, product.Price, product.Weight);          
            
        }

        public static void BuyInfo(Buy buy)
        {
            Console.WriteLine("Information about shopping cart:");
            Console.WriteLine(buy);
            
        }
    }
}
