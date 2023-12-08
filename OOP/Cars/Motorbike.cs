
namespace OOP.Cars
{
    internal class Motorbike : Auto
    {
        public bool IsHasSidecar { get; set; } = false;

        public Motorbike(string brand, string number, int speed, bool isHasSidecar, int inputLiftingCapacityWithSidecar) : base(brand, number, speed)
        {
            IsHasSidecar = isHasSidecar;
            LiftingCapacity = ComputeLiftingCapacity(inputLiftingCapacityWithSidecar);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nМотоцикл");
            base.PrintInfo();
            Console.WriteLine($"Есть коляска:       {IsHasSidecar}");
        }

        protected override int ComputeLiftingCapacity(int inputLiftingCapacityWithSidecar)
        {
            if (IsHasSidecar)
                return inputLiftingCapacityWithSidecar;
            return 0;
        }
    }
}
