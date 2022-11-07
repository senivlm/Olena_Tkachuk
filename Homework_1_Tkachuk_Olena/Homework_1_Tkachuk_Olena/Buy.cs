using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Tkachuk_Olena
{
    internal class Buy
    {       
       private List<Product> productList;

        public List<Product> ProductList
        {
            get
            {
                return new List<Product>(productList).ToList();               
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
        public Buy(params Product[] products)
        {
            productList = new List<Product>();

            for (int i = 0; i < products.Length; i++)
            {
                productList.Add(products[i]);
            }
        }
       
        public void TotalPriceOfProducts()
        {    

            double totalPrice = 0;       
                      
            foreach(Product item in productList)
            {
                totalPrice += item.Price;
            }          
         
            Console.WriteLine("\nTotal price: \n\t{0} UAH", totalPrice);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < productList.Count; i++)
            {
                result += $"{i + 1}. {productList[i].Name}\n";
            }

            return result;
        }

    }
}
