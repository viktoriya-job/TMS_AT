
namespace OOP.Cars
{
    internal class Truck : Auto
    {
        public bool IsTrailer { get; set; } = false;

        public Truck(string brand, string number, int speed, bool isTrailer) : base(brand, number, speed)
        {
            IsTrailer = isTrailer;
            LiftingCapacity = ComputeLiftingCapacity();
        }

        public override void GetInfo()
        {
            Console.WriteLine("\nГрузовой автомобиль");
            base.GetInfo();
            Console.WriteLine($"Есть прицеп:        {IsTrailer}");
        }

        protected override int ComputeLiftingCapacity()
        {
            if (IsTrailer)
                return 2 * LiftingCapacityTruck;
            return LiftingCapacityTruck;
        }
    }
}
