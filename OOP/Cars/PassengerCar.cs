
namespace OOP.Cars
{
    internal class PassengerCar : Auto
    {
        public PassengerCar(string brand, string number, int speed) : base(brand, number, speed)
        {
            LiftingCapacity = ComputeLiftingCapacity();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nЛегковой автомобиль");
            base.PrintInfo();
        }

        protected override int ComputeLiftingCapacity() => LiftingCapacityPassengerCar;
    }
}
