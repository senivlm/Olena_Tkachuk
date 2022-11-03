using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Product : IComparable
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

        public virtual void ChangePrice(double percent)
        {
            price *= percent;
            Console.WriteLine("New price with {0} percent: {1}", percent, Math.Round(Price, 2));
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Product)
            {
                return false;
            }
            else
            {
                Product other = (Product)obj;
                return Name == other.Name &&
                       Price == other.Price &&
                       Weight == other.Weight;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object? obj)
        {
            Product item = obj as Product;

            if (item != null)
            {
                return this.price.CompareTo(item.Price);
            }
            else
            {
                throw new Exception("Unable to compare");
            }

        }
    }
}
