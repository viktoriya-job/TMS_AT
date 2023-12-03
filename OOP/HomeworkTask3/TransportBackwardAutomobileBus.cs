
namespace OOP.TransportHierarchy
{
    internal class TransportBackwardAutomobileBus : TransportBackwardAutomobile
    {
        string transportKind = "Автобус";

        public TransportBackwardAutomobileBus() : base() => TransportKind = transportKind;

        public TransportBackwardAutomobileBus(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportBackwardAutomobileBus(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportBackwardAutomobileBus(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportBackwardAutomobileBus(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
