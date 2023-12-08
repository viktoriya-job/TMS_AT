
namespace OOP.TransportHierarchy
{
    internal class TransportAirAeronauticalAirship : TransportAirAeronautical
    {
        private string _transportKind = "Дирижабль";

        public TransportAirAeronauticalAirship() : base() => TransportKind = _transportKind;

        public TransportAirAeronauticalAirship(string number) : this() => Number = number;

        public TransportAirAeronauticalAirship(string number, string destination) : this(number) => Destination = destination;

        public TransportAirAeronauticalAirship(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportAirAeronauticalAirship(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportAirAviationAirplane : TransportAirAviation
    {
        private string _transportKind = "Самолет";

        public TransportAirAviationAirplane() : base() => TransportKind = _transportKind;

        public TransportAirAviationAirplane(string number) : this() => Number = number;

        public TransportAirAviationAirplane(string number, string destination) : this(number) => Destination = destination;

        public TransportAirAviationAirplane(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportAirAviationAirplane(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportBackwardAutomobileBus : TransportBackwardAutomobile
    {
        private string _transportKind = "Автобус";

        public TransportBackwardAutomobileBus() : base() => TransportKind = _transportKind;

        public TransportBackwardAutomobileBus(string number) : this() => Number = number;

        public TransportBackwardAutomobileBus(string number, string destination) : this(number) => Destination = destination;

        public TransportBackwardAutomobileBus(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportBackwardAutomobileBus(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportBackwardAutomobileTrolleybus : TransportBackwardAutomobile
    {
        private string _transportKind = "Троллейбус";

        public TransportBackwardAutomobileTrolleybus() : base() => TransportKind = _transportKind;

        public TransportBackwardAutomobileTrolleybus(string number) : this() => Number = number;

        public TransportBackwardAutomobileTrolleybus(string number, string destination) : this(number) => Destination = destination;

        public TransportBackwardAutomobileTrolleybus(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportBackwardAutomobileTrolleybus(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportBackwardRailwayTram : TransportBackwardRailway
    {
        private string _transportKind = "Трамвай";

        public TransportBackwardRailwayTram() : base() => TransportKind = _transportKind;

        public TransportBackwardRailwayTram(string number) : this() => Number = number;

        public TransportBackwardRailwayTram(string number, string destination) : this(number) => Destination = destination;

        public TransportBackwardRailwayTram(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportBackwardRailwayTram(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportWaterRiverFerry : TransportWaterRiver
    {
        private string _transportKind = "Паром";

        public TransportWaterRiverFerry() : base() => TransportKind = _transportKind;

        public TransportWaterRiverFerry(string number) : this() => Number = number;

        public TransportWaterRiverFerry(string number, string destination) : this(number) => Destination = destination;

        public TransportWaterRiverFerry(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportWaterRiverFerry(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportWaterSeaCruiseShip : TransportWaterSea
    {
        private string _transportKind = "Круизный Лайнер";

        public TransportWaterSeaCruiseShip() : base() => TransportKind = _transportKind;

        public TransportWaterSeaCruiseShip(string number) : this() => Number = number;

        public TransportWaterSeaCruiseShip(string number, string destination) : this(number) => Destination = destination;

        public TransportWaterSeaCruiseShip(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportWaterSeaCruiseShip(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }
}
