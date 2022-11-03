namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Changed price for product category:");
            Product bread = new Product("White bread", 20, 0.7);
            Product apples = new Product("Green apples", 18, 1);
            bread.ChangePrice(0.5);
            Console.WriteLine();
           

            Meat pork = new Meat("Pork", 120, 1, MeatCategory.Higher, TypesOfMeat.Pork);
            Meat lamb = new Meat("Lamb", 234, 1, MeatCategory.First, TypesOfMeat.Lamb);
            Console.WriteLine("Changed price for meat:");
            pork.ChangePrice(0.5);
            Console.WriteLine();

            Product milk = new Dairy_products("Milk", 33.0, 1, 10);
            Console.WriteLine("Changed price for dairy products:");
            milk.ChangePrice(0.95);
            Console.WriteLine();

            Storage storage = new Storage();
            Console.WriteLine("Storage data information");
            storage.DataInformation();
            Console.WriteLine();

            Console.WriteLine("Storage console information");
            storage.ConsoleInfo();
            Console.WriteLine();

            Product[] testProducts = { bread, apples, milk, pork, lamb};
            Storage storageProducts = new Storage(testProducts);
            Console.WriteLine("All meet what we have found:");
            storageProducts.FindMeat();
            storageProducts.ChangePrice(0.5);


        }
    }
}