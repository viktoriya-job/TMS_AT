
namespace OOP.TransportHierarchy
{
    internal class TransportBackwardRailwayTram : TransportBackwardRailway
    {
        string transportKind = "Трамвай";

        public TransportBackwardRailwayTram() : base() => TransportKind = transportKind;

        public TransportBackwardRailwayTram(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportBackwardRailwayTram(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportBackwardRailwayTram(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportBackwardRailwayTram(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
