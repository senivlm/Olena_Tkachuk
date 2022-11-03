namespace Homework_5_Tkachuk_Olena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("White bread", 0.5, Currency.EUR, 900, WeightOfProduct.Gr);
            Product bread2 = new Product("Bread", 22, Currency.UAH, 880, WeightOfProduct.Gr);
            Product cookies = new Product("Choco cookies", 65.90, Currency.UAH, 1, WeightOfProduct.Kg);
            Product apples = new Product("Green apples", 19.50, Currency.UAH, 1, WeightOfProduct.Kg);
            Product apples2 = new Product("Red apples", 22, Currency.UAH, 1, WeightOfProduct.Kg);
            Product cheese = new Product("Cheese", 1, Currency.USD, 100, WeightOfProduct.Gr);

            Check.ProductInfo(bread);

            Dictionary<Product, int> buyList = new Dictionary<Product, int>()
            {
                { bread, 1 },
                { bread2, 2 },
                {cookies, 3 },
                {cheese, 2 }
            };

            Buy buy = new Buy(buyList);
            Buy.AddProductToBasket(buyList);

            Check.BuyInfo(buyList);
            Buy.TotalPriceOfProducts(buyList);

        }
    }
}