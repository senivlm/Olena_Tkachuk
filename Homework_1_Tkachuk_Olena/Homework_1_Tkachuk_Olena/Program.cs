namespace Homework_1_Tkachuk_Olena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product("Milk", 32.45, 1);
            Product bread = new Product("Bread", 20.30, 0.7);
            Product orangeJuice = new Product("Orange juice", 45.50, 0.9);
            Product meat = new Product("Beef", 150, 1);
                        
            Check.ProductInfo(milk);
            Check.ProductInfo(bread);
            Check.ProductInfo(meat);

            Dictionary<Product, int> buyList = new Dictionary<Product, int>()
            {
                {milk, 2 },
                {bread, 1 },
                {meat, 1 }
            };

            Check.BuyInfo(buyList);

            Buy.TotalPriceOfProducts(buyList);

            Console.ReadKey();
        }
    }
}