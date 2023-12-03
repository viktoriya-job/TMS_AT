
namespace OOP.TransportHierarchy
{
    internal class TransportWater : Transport
    {
        public TransportWater() : base()
        {
            TransportType = "Водный транспорт";
        }

        public override string GetTransportInfo() => "Тип: " + TransportType;
    }
    /*

    internal class TransportAir : Transport
    {
        public TransportAir() : base()
        {
            TransportType = "Воздушный транспорт";
        }

        public TransportAir(string number) : base(number) { }

        public TransportAir(string number, string destination) : base(number, destination) { }

        public TransportAir(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportAir(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo() => "Тип: " + TransportType;
    }

    internal class TransportBackward : Transport
    {
        public TransportBackward() : base()
        {
            TransportType = "Наземный транспорт";
        }

        public TransportBackward(string number) : base(number) { }

        public TransportBackward(string number, string destination) : base(number, destination) { }

        public TransportBackward(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportBackward(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo() => "Тип: " + TransportType;
    }

    */
}
