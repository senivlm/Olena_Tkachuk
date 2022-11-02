using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Dairy_products : Product
    {
        private int productsExpiration;

        public int ProductsExpiration
        {
            get;
            set;
        }

        public Dairy_products(string name, double price, double weight, int productsExpiration) : base (name, price, weight)
        {
            ProductsExpiration = productsExpiration;
        }

        public override void ChangePrice(double percent)
        {
            base.ChangePrice(percent);

            if (productsExpiration == 0)
            {
                base.ChangePrice(0.5);
            }
            else if (productsExpiration < 0)
            {
                base.ChangePrice(0.1);
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}, Expiration: {ProductsExpiration}";
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not Dairy_products)
            {
                return false;
            }
            else
            {
                Dairy_products other = (Dairy_products)obj;
                return ProductsExpiration == other.ProductsExpiration;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
