
namespace OOP.TransportHierarchy
{
    internal class TransportAirAviationAirplane : TransportAirAviation
    {
        string transportKind = "Самолет";

        public TransportAirAviationAirplane() : base() => TransportKind = transportKind;

        public TransportAirAviationAirplane(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportAirAviationAirplane(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportAirAviationAirplane(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportAirAviationAirplane(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
