
namespace OOP.TransportHierarchy
{
    internal class TransportWater : Transport
    {
        public TransportWater() : base() => TransportType = "Водный транспорт";

        public override string GetTransportInfo() => base.PrintTransportInfo('~');

    }

    internal class TransportAir : Transport
    {
        public TransportAir() : base() => TransportType = "Воздушный транспорт";

        public override string GetTransportInfo() => base.PrintTransportInfo('*');
    }

    internal class TransportBackward : Transport
    {
        public TransportBackward() : base() => TransportType = "Наземный транспорт";

        public override string GetTransportInfo() => base.PrintTransportInfo('=');
    }
}
