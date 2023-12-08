
namespace OOP.TransportHierarchy
{
    internal abstract class TransportWaterRiver : TransportWater
    {
        public TransportWaterRiver() : base() => TransportSubTypeByTravelMedium = "Речной";
    }

    internal abstract class TransportWaterSea : TransportWater
    {
        public TransportWaterSea() : base() => TransportSubTypeByTravelMedium = "Морской";
    }

    internal abstract class TransportAirAviation : TransportAir
    {
        public TransportAirAviation() : base() => TransportSubTypeByTravelMedium = "Авиационный";
    }

    internal abstract class TransportAirAeronautical : TransportAir
    {
        public TransportAirAeronautical() : base() => TransportSubTypeByTravelMedium = "Воздухоплавательный";
    }

    internal abstract class TransportBackwardRailway : TransportBackward
    {
        public TransportBackwardRailway() : base() => TransportSubTypeByTravelMedium = "Железнодорожный";
    }

    internal abstract class TransportBackwardAutomobile : TransportBackward
    {
        public TransportBackwardAutomobile() : base() => TransportSubTypeByTravelMedium = "Автомобильный";
    }
}
