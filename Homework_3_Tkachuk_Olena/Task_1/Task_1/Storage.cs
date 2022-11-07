using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Storage
    {
        public List<Product> productsArray;

        public int typeOfProduct;
        public string nameOfProduct;
        public double priceOfProduct;
        public double weightOfProduct;
        public MeatCategory categoryOfMeat;
        public TypesOfMeat typeOfMeat;
        public int expirationOfProduct;

        public List<Product> ProductsArray
        {
            get { return productsArray; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    productsArray = value;
                }
            }
        }

        public Storage(List<Product> productsArray)
        {
            this.productsArray = new List<Product>();
                     
        }

        public Storage()
        {            
            this.productsArray = new List<Product>();
            this.typeOfProduct = 0;
            this.priceOfProduct = 0;
            this.weightOfProduct = 0;
            this.expirationOfProduct = 0;
            this.nameOfProduct = "";
        }

        public Product this[int index]
        {
            get
            {
                if (index < 0 || index > productsArray.Count())
                {
                    throw new ArgumentException("Index Out Of Range Exception");
                }
                return productsArray[index];                    
            }
            set
            {
                if (index < 0 || index > productsArray.Count())
                {
                    throw new ArgumentException("Index Out Of Range Exception");
                }
                productsArray[index] = value;                
            }
        }

        public void ConsoleInfo()
        {
            Console.WriteLine("How much product do you want to enter?");
            int number = Int32.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();            

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("What kind of product: 1 - product, 2 - meat, 3 - dairy product");
                typeOfProduct = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please, enter a name of the product: ");
                nameOfProduct = Console.ReadLine();

                Console.WriteLine("Please, enter a price of the product: ");
                priceOfProduct = Double.Parse(Console.ReadLine());

                Console.WriteLine("What weight the product has: ");
                weightOfProduct = Double.Parse(Console.ReadLine());

                switch(typeOfProduct)
                {
                    case 1:
                        {
                            products.Add(new Product(nameOfProduct, priceOfProduct, weightOfProduct));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Choose the category of meet: Higher, First or Second: ");
                            categoryOfMeat = (MeatCategory)Enum.Parse(typeof(MeatCategory), Console.ReadLine());

                            Console.WriteLine("Choose the type of meat: Lamb, Veal, Pork or Chicken");
                            typeOfMeat = (TypesOfMeat)Enum.Parse(typeof(TypesOfMeat), Console.ReadLine());

                            products.Add(new Meat(nameOfProduct, priceOfProduct, weightOfProduct, categoryOfMeat, typeOfMeat));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please, enter an expiration of the dairy product: ");
                            expirationOfProduct = Int32.Parse(Console.ReadLine());

                            products.Add(new Dairy_products(nameOfProduct, priceOfProduct, weightOfProduct, expirationOfProduct));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Something wrong!");
                            break;
                        }                
                }
            
            }
            CheckProductsConsoleInfo(number);
        }

        public void DataInformation()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Bread", 12, 0.7),
                new Product("Sausage", 66.00, 0.5),
                new Product("Cheese", 78.50, 0.1),
                new Product("Cookies", 50.25, 0.1),
                new Product("Apples", 18.00, 1)
            };

            Check.CheckDataInformation(products);
            Console.WriteLine();

            List<Product> meat = new List<Product>()
            {
                new Meat("Nice Lamb", 150, 1, MeatCategory.Higher, TypesOfMeat.Lamb),
                new Meat("Taaty Veal", 167.00, 1, MeatCategory.First, TypesOfMeat.Veal),
                new Meat("Great Pork", 100, 1, MeatCategory.First, TypesOfMeat.Pork),
                new Meat("Home Chicken", 105.60, 1, MeatCategory.Higher, TypesOfMeat.Chicken)
            };
            Check.CheckDataInformation(meat);
            Console.WriteLine();

            List<Product> dairyProducts = new List<Product>()
            {
                new Dairy_products("Milk 2,5%", 33, 0.9, 5),
                new Dairy_products("Strawberry Yogurt", 50, 0.5, 10),
                new Dairy_products("Farmer cheese", 40, 0.2, 15),
                new Dairy_products("Kefir", 25.75, 1, 20)
            };

            Check.CheckDataInformation(dairyProducts);            
        }

        public void CheckProductsConsoleInfo(int size)
        {            
            if (typeOfProduct == 1)
            {
                Console.WriteLine("Information about new product:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Name: \t{0};\nPrice: \t{1};\nWeight: {2}\n",
                        nameOfProduct, priceOfProduct, weightOfProduct);
                }
            }
            else if (typeOfProduct == 2)
            {
                Console.WriteLine("Information about new meat:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Name: \t{0};\nPrice: \t{1};\nWeight: {2};\nCategory: {3};\nSort: \t{4}\n",
                        nameOfProduct, priceOfProduct, weightOfProduct, categoryOfMeat, typeOfMeat);
                }
            }
            else if (typeOfProduct == 3)
            {
                Console.WriteLine("Information about new dairy product:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Name: \t{0};\nPrice: \t{1};\nWeight: {2};\nExspiration: {3}\n",
                        nameOfProduct, priceOfProduct, weightOfProduct, expirationOfProduct);
                }
            }
            else
            {
                Console.WriteLine("Unknown product");
            }
        }

        public void FindMeat(List<Product> productsArray)
        {
            int counter = 0;

            foreach(var item in productsArray)
            {
                if (item.GetType() == typeof(Meat))
                {
                    Console.WriteLine(item.Name);
                    counter++;
                }
            }
            
            Console.WriteLine("Number of meat: {0}", counter);
        }

        public void ChangePrice(double percent)
        {
            for (int i = 0; i < productsArray.Count(); i++)
            {
                ProductsArray[i].ChangePrice(percent);
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < ProductsArray.Count(); i++)
            {
                result += ProductsArray[i] + "/n";
            }
            return $"Product: {result}";
        }
    }
}
