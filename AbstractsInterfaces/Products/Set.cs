
namespace AbstractsInterfaces.Products
{
    internal class Set : Product
    {
        public List<Foodstuff> FoodstaffList { get; set; }

        public Set(string title, float price, List<Foodstuff> foodstaffList) : base(title, price)
        {
            FoodstaffList = foodstaffList;
        }

        public override bool IsNotExpired()
        {
            foreach (var food in FoodstaffList)
                if (!food.IsNotExpired())
                    return false;
            return true;
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
