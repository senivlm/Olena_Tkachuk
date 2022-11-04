namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumbersArray array = new NumbersArray(10, 1, 10);
            array.FindSubsequences();
            Console.WriteLine("--------------------------------");
            array.FrequencyTable();
            Console.WriteLine("--------------------------------");

            NumbersArray array2 = new NumbersArray(20, 1, 10);
            array2.FindSubsequences();
            Console.WriteLine("--------------------------------");
            array2.FrequencyTable();
            Console.WriteLine("--------------------------------");

        }
    }
}