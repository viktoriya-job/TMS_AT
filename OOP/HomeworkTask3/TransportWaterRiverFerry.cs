

namespace OOP.TransportHierarchy
{
    internal class TransportWaterRiverFerry : TransportWaterRiver
    {
        string transportKind = "Паром";

        public TransportWaterRiverFerry() : base() => TransportKind = transportKind;

        public TransportWaterRiverFerry(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportWaterRiverFerry(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportWaterRiverFerry(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportWaterRiverFerry(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
