

namespace OOP.TransportHierarchy
{
    internal class TransportWaterRiver : TransportWater
    {
        public string TransportSubType { get; } = "Речной";

        public override string GetTransportInfo()
        {
            return ($"""

                {new string('~', 35)}
                Тип:    {TransportSubType} {TransportType}
                """);
        }
    }
/*
    internal class TransportWaterSea : TransportWater
    {
        public string TransportSubType { get; } = "Морской";

        public TransportWaterSea() { }

        public TransportWaterSea(string number) : base(number) { }

        public TransportWaterSea(string number, string destination) : base(number, destination) { }

        public TransportWaterSea(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportWaterSea(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo()
        {
            return ($"""

                {new string('~', 35)}
                Тип:    {TransportSubType} {TransportType}
                """);
        }
    }

    internal class TransportAirAviation : TransportAir
    {
        public string TransportSubType { get; } = "Авиационный";

        public TransportAirAviation() { }

        public TransportAirAviation(string number) : base(number) { }

        public TransportAirAviation(string number, string destination) : base(number, destination) { }

        public TransportAirAviation(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportAirAviation(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo()
        {
            return ($"""

                {new string('@', 35)}
                Тип:    {TransportSubType} {TransportType}
                """);
        }
    }

    internal class TransportAirAeronautical : TransportAir
    {
        public string TransportSubType { get; } = "Воздухоплавательный";

        public TransportAirAeronautical() { }

        public TransportAirAeronautical(string number) : base(number) { }

        public TransportAirAeronautical(string number, string destination) : base(number, destination) { }

        public TransportAirAeronautical(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportAirAeronautical(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo()
        {
            return ($"""

                {new string('*', 35)}
                Тип:    {TransportSubType} {TransportType}
                """);
        }
    }
    internal class TransportBackwardRailway : TransportBackward
    {
        public string TransportSubType { get; } = "Железнодорожный";

        public TransportBackwardRailway() { }

        public TransportBackwardRailway(string number) : base(number) { }

        public TransportBackwardRailway(string number, string destination) : base(number, destination) { }

        public TransportBackwardRailway(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportBackwardRailway(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo()
        {
            return ($"""

                {new string('=', 35)}
                Тип:    {TransportSubType} {TransportType}
                """);
        }
    }

    internal class TransportBackwardAutomobile : TransportBackward
    {
        public string TransportSubType { get; } = "Автомобильный";

        public TransportBackwardAutomobile() { }

        public TransportBackwardAutomobile(string number) : base(number) { }

        public TransportBackwardAutomobile(string number, string destination) : base(number, destination) { }

        public TransportBackwardAutomobile(string number, string destination, DateTime departureTime) : base(number, destination, departureTime) { }

        public TransportBackwardAutomobile(string number, string destination, DateTime departureTime, int seatsNumber) : base(number, destination, departureTime, seatsNumber) { }

        public override string GetTransportInfo()
        {
            return ($"""

                {new string('_', 35)}
                Тип:    {TransportSubType} {TransportType}
                """);
        }
    }
*/
}
