
namespace AbstractsInterfaces.Products
{
    internal class Set : Product
    {
        public List<Foodstuff> FoodstaffList { get; set; }

        public Set(string title, float price, List<Foodstuff> foodstaffList) : base(title, price)
        {
            FoodstaffList = foodstaffList;
        }

        public override bool IsExpired()
        {
            foreach (var food in FoodstaffList)
                if (food.IsExpired())
                    return true;
            return false;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Состав набора:");

            foreach (var food in FoodstaffList)
                Console.WriteLine($" - {food.Title}");
        }
    }
}
