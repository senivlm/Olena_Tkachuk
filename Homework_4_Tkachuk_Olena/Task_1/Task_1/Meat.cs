using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public enum MeatCategory
    {
        Higher,
        First,
        Second
    }

    public enum TypesOfMeat
    {
        Lamb,
        Veal,
        Pork,
        Chicken
    }
    internal class Meat : Product
    {
        private MeatCategory category;
        private TypesOfMeat meatSort;

        public MeatCategory Category
        {
            get;
            set;
        }

        public TypesOfMeat MeatSort
        {
            get;
            set;
        }

        public Meat(string name, double price, double weight, MeatCategory category, TypesOfMeat meatSort) : base(name, price, weight)
        {
            Category = category;
            MeatSort = meatSort;
        }

        public override void ChangePrice(double percent)
        {
            base.ChangePrice(percent);

            switch (Category)
            {
                case MeatCategory.Higher:
                    {
                        base.ChangePrice(1.5);
                        break;
                    }
                case MeatCategory.First:
                    {
                        base.ChangePrice(1.25);
                        break;
                    }
                case MeatCategory.Second:
                    {
                        base.ChangePrice(1.05);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Choose category of meat: Higher, First, Second");
                        break;
                    }
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Meat)
            {
                return false;
            }
            else
            {
                Meat other = (Meat)obj;
                return Category == other.Category &&
                       MeatSort == other.MeatSort;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}, Category: {Category}, Sort of meat: {MeatSort}";
        }
    }
}
