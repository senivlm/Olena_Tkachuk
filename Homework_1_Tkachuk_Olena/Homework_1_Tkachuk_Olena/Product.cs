using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Tkachuk_Olena
{
    internal class Product
    {        
        private string name = "";
        private double price, weight;    

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The name of product can not be empty");
                }
                else
                {
                    name = value;
                }    
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price can not be null or negative");
                }
                else
                {
                    price = value;
                }
            }
        }
        
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The weight can not be zero or negative");
                }
                else
                {
                    weight = value;
                }
            }
        }
        
        public Product()
        {
            Name = name;
            Price = price;
            Weight = weight;           
        }

        public Product(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name + " " + Price + " " + Weight;
        }

    }
}
