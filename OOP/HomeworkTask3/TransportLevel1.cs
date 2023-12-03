
namespace OOP.TransportHierarchy
{
    internal class TransportWater : Transport
    {
        public TransportWater() : base() => TransportType = "Водный транспорт";

        public override string GetTransportInfo()
        {
            return ($"""
                {new string('~', 45)}
                Тип:    {TransportSubType} {base.GetTransportInfo()}
                Вид:    {TransportKind}

                Номер:              {Number}
                Пункт назначения:   {Destination}
                Время отправления   {DepartureTime}
                Число мест:         {SeatsNumber}
                {new string('~', 45)}
                """);
        }
    }

    internal class TransportAir : Transport
    {
        public TransportAir() : base() => TransportType = "Воздушный транспорт";

        public override string GetTransportInfo()
        {
            return ($"""
                {new string('*', 45)}
                Тип:    {TransportSubType} {base.GetTransportInfo()}
                Вид:    {TransportKind}

                Номер:              {Number}
                Пункт назначения:   {Destination}
                Время отправления   {DepartureTime}
                Число мест:         {SeatsNumber}
                {new string('*', 45)}
                """);
        }
    }

    internal class TransportBackward : Transport
    {
        public TransportBackward() : base() => TransportType = "Наземный транспорт";

        public override string GetTransportInfo()
        {
            return ($"""
                {new string('=', 45)}
                Тип:    {TransportSubType} {base.GetTransportInfo()}
                Вид:    {TransportKind}

                Номер:              {Number}
                Пункт назначения:   {Destination}
                Время отправления   {DepartureTime}
                Число мест:         {SeatsNumber}
                {new string('=', 45)}
                """);
        }
    }
}
