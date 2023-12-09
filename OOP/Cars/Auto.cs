
namespace OOP.Cars
{
    internal abstract class Auto
    {
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
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

        protected abstract int ComputeLiftingCapacity(int InputLiftingCapacity);
    }
}
