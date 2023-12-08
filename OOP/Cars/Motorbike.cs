
namespace OOP.Cars
{
    internal class Motorbike : Auto
    {
        public bool IsHasSidecar { get; set; } = false;

        public Motorbike(string brand, string number, int speed, bool isHasSidecar) : base(brand, number, speed)
        {
            IsHasSidecar = isHasSidecar;
            LiftingCapacity = ComputeLiftingCapacity();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nМотоцикл");
            base.PrintInfo();
            Console.WriteLine($"Есть коляска:       {IsHasSidecar}");
        }

        protected override int ComputeLiftingCapacity()
        {
            if (IsHasSidecar)
                return LiftingCapacityMotorbikeWithSidecar;
            return 0;
        }
    }
}
