using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Storage
    {
        public Product[] productsArray;

        public int typeOfProduct = 0;
        public string nameOfProduct = "";
        public double priceOfProduct = 0;
        public double weightOfProduct = 0;
        public int numberOfProduct = 0;
        public MeatCategory categoryOfMeat;
        public TypesOfMeat typeOfMeat;
        public int expirationOfProduct = 0;

        public Product[] ProductsArray
        {
            get;
            set;
        }


        public Storage(Product[] productsArray)
        {
            if(productsArray == null)
            {
                throw new ArgumentNullException("array");
            }
            else
            {
                ProductsArray = productsArray;
            }
        }

        public Storage()
        {
            
                ProductsArray = productsArray;
            
        }

        public Product this[int index]
        {
            get
            {
                try
                {
                    return ProductsArray[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new ArgumentException(e.Message);
                }                
            }
            set
            {                
                try
                {
                    ProductsArray[index] = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new ArgumentException(e.Message);
                }
            }
        }

        public void ConsoleInfo()
        {
            Console.WriteLine("How much product do you want to buy?");
            int number = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("What kind of product do you want to buy: 1 - product, 2 - meat, 3 - dairy product");
                typeOfProduct = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please, enter a name of the product: ");
                nameOfProduct = Console.ReadLine();

                Console.WriteLine("Please, enter a price of the choosen product: ");
                priceOfProduct = Double.Parse(Console.ReadLine());

                Console.WriteLine("What weight the product has: ");
                weightOfProduct = Double.Parse(Console.ReadLine());

                switch(typeOfProduct)
                {
                    case 1:
                        {
                            ProductsArray[i] = new Product(nameOfProduct, priceOfProduct, weightOfProduct);
                            CheckProductsConsoleInfo();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Choose the category of meet: Higher, First or Second: ");
                            categoryOfMeat = (MeatCategory)Enum.Parse(typeof(MeatCategory), Console.ReadLine());

                            Console.WriteLine("Choose the type of meat: lamb, veal, pork or chicken");
                            typeOfMeat = (TypesOfMeat)Enum.Parse(typeof(TypesOfMeat), Console.ReadLine());

                            ProductsArray[i] = new Meat(nameOfProduct, priceOfProduct, weightOfProduct, categoryOfMeat, typeOfMeat);
                            CheckProductsConsoleInfo();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please, enter an expiration of the dairy product: ");
                            expirationOfProduct = Int32.Parse(Console.ReadLine());

                            ProductsArray[i] = new Dairy_products(nameOfProduct, priceOfProduct, weightOfProduct, expirationOfProduct);
                            CheckProductsConsoleInfo();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Something wrong!");
                            break;
                        }                
                }
            
            }    
        }

        public void DataInformation()
        {
            Product[] products = new Product[]
            {
                new Product("Bread", 12, 0.7),
                new Product("Sausage", 66.00, 0.5),
                new Product("Cheese", 78.50, 0.1),
                new Product("Cookies", 50.25, 0.1),
                new Product("Apples", 18.00, 1)
            };

            Console.WriteLine("Our products:");
            foreach (Product product in products)
            {
                Console.WriteLine("Name: {0}; Price: {1}; Weight: {2}", 
                    product.Name, product.Price, product.Weight);
            }
            Console.WriteLine();

            Meat[] meat = new Meat[]
            {
                new Meat("Nice Lamb", 150, 1, MeatCategory.Higher, TypesOfMeat.Lamb),
                new Meat("Taaty Veal", 167.00, 1, MeatCategory.First, TypesOfMeat.Veal),
                new Meat("Great Pork", 100, 1, MeatCategory.First, TypesOfMeat.Pork),
                new Meat("Home Chicken", 105.60, 1, MeatCategory.Higher, TypesOfMeat.Chicken)
            };

            Console.WriteLine("Our meat:");
            foreach (Meat item in meat)
            {
                Console.WriteLine("Name: {0}; Price: {1}; Weight: {2}; Category: {3}; Sort: {4};",
                    item.Name, item.Price, item.Weight, item.Category, item.MeatSort);
            }
            Console.WriteLine();

            Dairy_products[] dairy_Products = new Dairy_products[]
            {
                new Dairy_products("Milk 2,5%", 33, 0.9, 5),
                new Dairy_products("Strawberry Yogurt", 50, 0.5, 10),
                new Dairy_products("Farmer cheese", 40, 0.2, 15),
                new Dairy_products("Kefir", 25.75, 1, 20)
            };

            Console.WriteLine("Our dairy products:");
            foreach (Meat item in meat)
            {
                Console.WriteLine("Name: {0}; Price: {1}; Weight: {2}; Category: {3}; Sort: {4}",
                    item.Name, item.Price, item.Weight, item.Category, item.MeatSort);
            }
        }

        public void CheckProductsConsoleInfo()
        {
            if (typeOfProduct == 1)
            {
                Console.WriteLine("Information about product:");
                foreach (var item in ProductsArray)
                {
                    Console.WriteLine("Name: \t{0},\nPrice: \t{1},\nWeight: \t{2},\n",
                        nameOfProduct, priceOfProduct, weightOfProduct);
                }
            }
            else if (typeOfProduct == 2)
            {
                Console.WriteLine("Information about meat:");
                foreach (var item in ProductsArray)
                {
                    Console.WriteLine("Name: \t{0},\nPrice: \t{1},\nWeight: \t{2},\nCategory: \t{3},\nSort: \t{4}\n",
                        nameOfProduct, priceOfProduct, weightOfProduct, categoryOfMeat, typeOfMeat);
                }
            }
            else if (typeOfProduct == 3)
            {
                Console.WriteLine("Information about dairy product:");
                foreach (var item in ProductsArray)
                {
                    Console.WriteLine("Name: \t{0},\nPrice: \t{1},\nWeight: \t{2},\nExspiration: \t{3}\n",
                        nameOfProduct, priceOfProduct, weightOfProduct, expirationOfProduct);
                }
            }
            else
            {
                Console.WriteLine("Unknown product");
            }
        }

        public void FindMeat()
        {
            int counter = 0;

            foreach(var item in ProductsArray)
            {
                if(typeof(Meat).IsAssignableFrom(item.GetType()))
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("The item does not exist!");
                }
            }
        }

        public void ChangePrice(double percent)
        {
            for (int i = 0; i < ProductsArray.Length; i++)
            {
                ProductsArray[i].ChangePrice(percent);
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < ProductsArray.Length; i++)
            {
                result += ProductsArray[i] + "/n";
            }
            return $"Product: {result}";
        }
    }
}
