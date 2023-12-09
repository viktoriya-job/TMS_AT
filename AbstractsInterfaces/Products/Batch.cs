
namespace AbstractsInterfaces.Products
{
    internal class Batch : Foodstuff
    {
        protected int Amount { get; set; }

        public Batch(string title, float price, DateOnly dateProduction, int shelfLife, int amount) : base(title, price, dateProduction, shelfLife)
        {
            Amount = amount;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"""
                Количество шт:      {Amount}
                """);
        }
    }
}
