namespace Generics
{
    internal class Car<T> where T : Engine
    {
        public T CarType { get; set; }
        public string Model { get; set; }

        public Car(T carType) => CarType = carType;

        public void Run()
        {
            Console.WriteLine("Автомобиль едет");
        }
    }
}