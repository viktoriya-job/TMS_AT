
namespace OOP.Cars
{
    internal class Truck : Auto
    {
        public bool IsHasTrailer { get; set; } = false;

        public Truck(string brand, string number, int speed, bool isHasTrailer) : base(brand, number, speed)
        {
            IsHasTrailer = isHasTrailer;
            LiftingCapacity = ComputeLiftingCapacity();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nГрузовой автомобиль");
            base.PrintInfo();
            Console.WriteLine($"Есть прицеп:        {IsHasTrailer}");
        }

        protected override int ComputeLiftingCapacity()
        {
            if (IsHasTrailer)
                return 2 * LiftingCapacityTruckWithoutTrailer;
            return LiftingCapacityTruckWithoutTrailer;
        }
    }
}
