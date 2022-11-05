namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("White bread", 18.25, 0.8);
            Product productMeat = new Meat("Lamb", 120.45, 1, MeatCategory.Higher, TypesOfMeat.Lamb);
            Product orange = new Product("Sweet oranges", 55.70, 1);
            Product bread2 = new Product("White bread", 18.25, 0.8);
            Meat pork = new Meat("Pork", 90.00, 1, MeatCategory.First, TypesOfMeat.Pork);
            Meat chicken = new Meat("Chicken", 100.00, 1, MeatCategory.Higher, TypesOfMeat.Chicken);

            Console.WriteLine("Method 'Equals':");
            Console.WriteLine(bread.Equals(bread2));
            Console.WriteLine(bread.Equals(orange));
            Console.WriteLine(bread.Equals(productMeat));
            Console.WriteLine(productMeat.Equals(pork));
            Console.WriteLine(pork.Equals(chicken));
            Console.WriteLine();

                    
            Console.WriteLine("ICompare interface in the class Product(sort by lenght's name):");

            Product[] productAssortiment2 = { bread, chicken, orange };
            
            Array.Sort(productAssortiment2, new ProductComparerbyName());

            foreach(var item in productAssortiment2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( );

            Console.WriteLine("ICompare interface in the class Product(sort by price):");
            Array.Sort(productAssortiment2, new ProductComparerByPrice());

            foreach (var item in productAssortiment2)
            {
                Console.WriteLine(item);
            }
             
            Console.WriteLine();
            Product[] productAssortiment = { bread, productMeat, orange, pork, chicken };
            List<Product> list = new List<Product>()
            {
                new Product(" Green apples", 12, 1),
                new Meat("Home chicken", 100, 1, MeatCategory.First, TypesOfMeat.Chicken),
                new Product("ice-cream", 50, 0.4)
            };

            Storage storage = new Storage();
            storage.SortByPrice(list);
            storage.SortByName(list);
            storage.SortByWeight(list);



        }
    }
}