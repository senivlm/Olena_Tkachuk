using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Tkachuk_Olena
{
    public enum Currency
    {
        EUR,
        USD,
        UAH
    }

    public enum WeightOfProduct
    { 
        Kg,
        Gr
    }


    internal class Product
    {
        private string name = "";
        private double price;
        private double weight;
        public Currency Currency { get; set; }
        public WeightOfProduct WeightOfProduct { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
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
                if (value <= null)
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
                if (value <= null)
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

        public Product(string name, double price, Currency currency, double weight, WeightOfProduct weightOfProduct)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Currency = currency;
            WeightOfProduct = weightOfProduct;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price} {Currency}, Weight: {Weight} {WeightOfProduct}";
        }
    }
}
