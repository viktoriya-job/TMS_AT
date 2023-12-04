
namespace OOP.TransportHierarchy
{
    internal class TransportAirAeronauticalAirship : TransportAirAeronautical
    {
        string transportKind = "Дирижабль";

        public TransportAirAeronauticalAirship() : base() => TransportKind = transportKind;

        public TransportAirAeronauticalAirship(string number) : this() => Number = number;

        public TransportAirAeronauticalAirship(string number, string destination) : this(number) => Destination = destination;

        public TransportAirAeronauticalAirship(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportAirAeronauticalAirship(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportAirAviationAirplane : TransportAirAviation
    {
        string transportKind = "Самолет";

        public TransportAirAviationAirplane() : base() => TransportKind = transportKind;

        public TransportAirAviationAirplane(string number) : this() => Number = number;

        public TransportAirAviationAirplane(string number, string destination) : this(number) => Destination = destination;

        public TransportAirAviationAirplane(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportAirAviationAirplane(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportBackwardAutomobileBus : TransportBackwardAutomobile
    {
        string transportKind = "Автобус";

        public TransportBackwardAutomobileBus() : base() => TransportKind = transportKind;

        public TransportBackwardAutomobileBus(string number) : this() => Number = number;

        public TransportBackwardAutomobileBus(string number, string destination) : this(number) => Destination = destination;

        public TransportBackwardAutomobileBus(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportBackwardAutomobileBus(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportBackwardAutomobileTrolleybus : TransportBackwardAutomobile
    {
        string transportKind = "Троллейбус";

        public TransportBackwardAutomobileTrolleybus() : base() => TransportKind = transportKind;

        public TransportBackwardAutomobileTrolleybus(string number) : this() => Number = number;

        public TransportBackwardAutomobileTrolleybus(string number, string destination) : this(number) => Destination = destination;

        public TransportBackwardAutomobileTrolleybus(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportBackwardAutomobileTrolleybus(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportBackwardRailwayTram : TransportBackwardRailway
    {
        string transportKind = "Трамвай";

        public TransportBackwardRailwayTram() : base() => TransportKind = transportKind;

        public TransportBackwardRailwayTram(string number) : this() => Number = number;

        public TransportBackwardRailwayTram(string number, string destination) : this(number) => Destination = destination;

        public TransportBackwardRailwayTram(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportBackwardRailwayTram(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportWaterRiverFerry : TransportWaterRiver
    {
        string transportKind = "Паром";

        public TransportWaterRiverFerry() : base() => TransportKind = transportKind;

        public TransportWaterRiverFerry(string number) : this() => Number = number;

        public TransportWaterRiverFerry(string number, string destination) : this(number) => Destination = destination;

        public TransportWaterRiverFerry(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportWaterRiverFerry(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }

    internal class TransportWaterSeaCruiseShip : TransportWaterSea
    {
        string transportKind = "Круизный Лайнер";

        public TransportWaterSeaCruiseShip() : base() => TransportKind = transportKind;

        public TransportWaterSeaCruiseShip(string number) : this() => Number = number;

        public TransportWaterSeaCruiseShip(string number, string destination) : this(number) => Destination = destination;

        public TransportWaterSeaCruiseShip(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportWaterSeaCruiseShip(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;
    }
}
