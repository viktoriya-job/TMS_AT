
namespace OOP.TransportHierarchy
{
    internal class TransportBackwardAutomobileTrolleybus : TransportBackwardAutomobile
    {
        string transportKind = "Троллейбус";

        public TransportBackwardAutomobileTrolleybus() : base() => TransportKind = transportKind;

        public TransportBackwardAutomobileTrolleybus(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportBackwardAutomobileTrolleybus(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportBackwardAutomobileTrolleybus(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportBackwardAutomobileTrolleybus(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
