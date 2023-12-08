
namespace OOP.Cars
{
    internal abstract class Auto
    {
        protected const int LiftingCapacityPassengerCar = 500;
        protected const int LiftingCapacityTruckWithoutTrailer = 1000;
        protected const int LiftingCapacityMotorbikeWithSidecar = 200;

        public string Brand { get; set; } = "Не определен";
        public string Number { get; set; } = "Не определен";
        public int Speed { get; set; } = 0;
        public int LiftingCapacity { get; set; } = 0;

        public Auto(string brand, string number, int speed)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"""
                Марка               {Brand}
                Номер               {Number}
                Скорость            {Speed}
                Грузоподъемность    {LiftingCapacity}
                """);
        }

        protected abstract int ComputeLiftingCapacity();
    }
}
