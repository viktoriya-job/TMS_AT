
namespace OOP.TransportHierarchy
{
    internal abstract class TransportWater : TransportPublic
    {
        public TransportWater() : base() => TransportTypeByTravelMedium = "Водный транспорт";
    }

    internal abstract class TransportAir : TransportPublic
    {
        public TransportAir() : base() => TransportTypeByTravelMedium = "Воздушный транспорт";
    }

    internal abstract class TransportBackward : TransportPublic
    {
        public TransportBackward() : base() => TransportTypeByTravelMedium = "Наземный транспорт";
    }
}
