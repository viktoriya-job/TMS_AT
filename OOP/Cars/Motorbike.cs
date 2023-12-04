
namespace OOP.Cars
{
    internal class Motorbike : Auto
    {
        public bool IsSidecar { get; set; } = false;

        public Motorbike(string brand, string number, int speed, bool isSidecar) : base(brand, number, speed)
        {
            IsSidecar = isSidecar;
            LiftingCapacity = ComputeLiftingCapacity();
        }

        public override void GetInfo()
        {
            Console.WriteLine("\nМотоцикл");
            base.GetInfo();
            Console.WriteLine($"Есть коляска:       {IsSidecar}");
        }

        protected override int ComputeLiftingCapacity()
        {
            if (IsSidecar)
                return LiftingCapacityMotorbikeWithSidecar;
            return 0;
        }
    }
}
