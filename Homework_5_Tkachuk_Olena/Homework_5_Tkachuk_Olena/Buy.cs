using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Tkachuk_Olena
{
    
    internal class Buy
    {
        public Dictionary<Product, int> productList;
        
        public Dictionary<Product, int> ProductList
        {
            get
            {
                return productList;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    productList = value;
                }
            }
        }

        public Buy()
        {
            this.productList = new Dictionary<Product, int>();
        }
        public Buy(Dictionary<Product, int> productList)
        {            

            this.productList = new Dictionary<Product, int>();

        }        

        public static void AddProductToBasket(Dictionary<Product, int> productList)
        {
            
            foreach (Product product in productList.Keys)
            {
                if (product.Currency == Currency.USD)
                {
                   product.Price *= 39;
                   product.Currency = Currency.UAH;

                }
                else if (product.Currency == Currency.EUR)
                {
                    product.Price *= 40;
                    product.Currency = Currency.UAH;
                }
            }            
            
        }

        public static void TotalPriceOfProducts(Dictionary<Product, int> productList)
        {
            double totalPrice = 0;

            foreach (KeyValuePair<Product, int> item in productList)
            {                
                totalPrice += item.Value * item.Key.Price;                
            }

            Console.WriteLine("\nTotal price in the basket: \n\t{0} UAH", Math.Round(totalPrice, 2));
        }

    }
}
