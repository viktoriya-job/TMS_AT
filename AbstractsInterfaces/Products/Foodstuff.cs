
namespace AbstractsInterfaces.Products
{
    internal class Foodstuff : Product
    {
        protected DateOnly DateProduction { get; set; }
        protected int ShelfLife { get; set; }

        public Foodstuff(string title, float price, DateOnly dateProduction, int shelfLife) : base(title, price)
        {
            DateProduction = dateProduction;
            ShelfLife = shelfLife;
        }

        public override bool IsExpired() => DateProduction.AddDays(ShelfLife) <= DateOnly.FromDateTime(DateTime.Today);


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"""
                Дата производиства: {DateProduction}
                Срок годности:      {ShelfLife} дней
                """);
        }
    }
}
