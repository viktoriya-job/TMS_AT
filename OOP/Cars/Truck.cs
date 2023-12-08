
namespace OOP.Cars
{
    internal class Truck : Auto
    {
        public bool IsHasTrailer { get; set; } = false;

        public Truck(string brand, string number, int speed, bool isHasTrailer, int inputLiftingCapacityWithoutTrailer) : base(brand, number, speed)
        {
            IsHasTrailer = isHasTrailer;
            LiftingCapacity = ComputeLiftingCapacity(inputLiftingCapacityWithoutTrailer);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nГрузовой автомобиль");
            base.PrintInfo();
            Console.WriteLine($"Есть прицеп:        {IsHasTrailer}");
        }

        protected override int ComputeLiftingCapacity(int inputLiftingCapacityWithoutTrailer)
        {
            if (IsHasTrailer)
                return 2 * inputLiftingCapacityWithoutTrailer;
            return inputLiftingCapacityWithoutTrailer;
        }
    }
}
