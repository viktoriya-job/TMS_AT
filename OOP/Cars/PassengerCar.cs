
namespace OOP.Cars
{
    internal class PassengerCar : Auto
    {
        public PassengerCar(string brand, string number, int speed) : base(brand, number, speed) => LiftingCapacity = ComputeLiftingCapacity();

        protected override int ComputeLiftingCapacity() => LiftingCapacityPassengerCar;

        public override void GetInfo()
        {
            Console.WriteLine("\nЛегковой автомобиль");
            base.GetInfo();
        }
    }
}
