
namespace OOP.TransportHierarchy
{
    internal class TransportWaterRiverTram : TransportWaterRiver
    {
        string transportKind = "Речной трамвай";

        public TransportWaterRiverTram() : base() => TransportKind = transportKind;

        public TransportWaterRiverTram(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportWaterRiverTram(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportWaterRiverTram(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportWaterRiverTram(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
