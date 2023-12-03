
namespace OOP.TransportHierarchy
{
    internal class TransportWaterRiver : TransportWater
    {
        public TransportWaterRiver() : base() => TransportSubType = "Речной";
    }

    internal class TransportWaterSea : TransportWater
    {
        public TransportWaterSea() : base() => TransportSubType = "Морской";
    }

    internal class TransportAirAviation : TransportAir
    {
        public TransportAirAviation() : base() => TransportSubType = "Авиационный";
    }

    internal class TransportAirAeronautical : TransportAir
    {
        public TransportAirAeronautical() : base() => TransportSubType = "Воздухоплавательный";
    }

    internal class TransportBackwardRailway : TransportBackward
    {
        public TransportBackwardRailway() : base() => TransportSubType = "Железнодорожный";
    }

    internal class TransportBackwardAutomobile : TransportBackward
    {
        public TransportBackwardAutomobile() : base() => TransportSubType = "Автомобильный";
    }
}
