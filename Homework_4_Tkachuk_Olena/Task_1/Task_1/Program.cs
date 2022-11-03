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

            Product[] productAssortiment = { bread, productMeat, orange, pork, chicken };
            
            Product[] productAssortiment2 = { bread, bread2, orange };
            Storage storages2 = new Storage (productAssortiment2);

            Array.Sort(productAssortiment);
            Console.WriteLine("IComparable interface in the class Product (sort with price):");
            
            foreach(var item in productAssortiment)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("IComparable interface in the class Storage(sort with name):");

        }
    }
}