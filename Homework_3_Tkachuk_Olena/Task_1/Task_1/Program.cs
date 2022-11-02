namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product meat = new Product("lamb", 150, 1);
            Product meat2 = new Product("pork", 120, 1);
            meat.ChangePrice(0.5);
           

            Meat pork = new Meat("Pork", 120, 1, MeatCategory.Higher, TypesOfMeat.Pork);
            Meat lamb = new Meat("Lamb", 234, 1, MeatCategory.First, TypesOfMeat.Lamb);

            pork.ChangePrice(0.5);

            Product milk = new Dairy_products("Milk", 33.0, 1, 10);
            milk.ChangePrice(0.95);

            Storage storage = new Storage();
            storage.DataInformation();
            
        }
    }
}