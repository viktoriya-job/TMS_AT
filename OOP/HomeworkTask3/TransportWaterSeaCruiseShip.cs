using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.TransportHierarchy
{
    internal class TransportWaterSeaCruiseShip : TransportWaterSea
    {
        string transportKind = "Круизный Лайнер";

        public TransportWaterSeaCruiseShip() : base() => TransportKind = transportKind;

        public TransportWaterSeaCruiseShip(string number)
        {
            Number = number;
            TransportKind = transportKind;
        }

        public TransportWaterSeaCruiseShip(string number, string destination) : this(number)
        {
            Destination = destination;
            TransportKind = transportKind;
        }

        public TransportWaterSeaCruiseShip(string number, string destination, int seatsNumber) : this(number, destination)
        {
            SeatsNumber = seatsNumber;
            TransportKind = transportKind;
        }

        public TransportWaterSeaCruiseShip(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
        {
            DepartureTime = departureTime;
            TransportKind = transportKind;
        }
    }
}
