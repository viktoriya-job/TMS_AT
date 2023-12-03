
namespace OOP.TransportHierarchy
{
    internal class TransportAirAeronauticalAirship : TransportAirAeronautical
    {
        string transportKind = "Дирижабль";

        public TransportAirAeronauticalAirship() : base() => TransportKind = transportKind;

        public TransportAirAeronauticalAirship(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportAirAeronauticalAirship(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportAirAeronauticalAirship(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportAirAeronauticalAirship(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
