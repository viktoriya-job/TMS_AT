namespace OOP.TransportHierarchy
{
    internal class TransportWaterRiverTram : TransportWaterRiver
    {
        public string TransportKind { get; } = "Речной трамвай";

        public TransportWaterRiverTram(string number) => Number = number;

        public TransportWaterRiverTram(string number, string destination) : this(number) => Destination = destination;

        public TransportWaterRiverTram(string number, string destination, int seatsNumber) : this(number, destination) => SeatsNumber = seatsNumber;

        public TransportWaterRiverTram(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber) => DepartureTime = departureTime;







    //public string Number { get; set; } = "Не установлен";
    //public string Destination { get; set; } = "Не определен";

    //DateTime departureTime = DateTime.Now;

    //public DateTime DepartureTime
    //{
    //    get
    //    {
    //        return departureTime;
    //    }
    //    set
    //    {
    //        if (value < DateTime.Now)
    //            PrintRedText("Дата отправления не может быть меньше текущей");
    //        else
    //            departureTime = value;
    //    }
    //}

    //int seatsNumber = 1;
    //public int SeatsNumber
    //{
    //    get
    //    {
    //        return seatsNumber;
    //    }
    //    set
    //    {
    //        if (value < 1)
    //            PrintRedText("Число мест должно быть больше 0");
    //        else
    //            seatsNumber = value;
    //    }
    //}

    //public TransportWaterRiverTram()
    //{
    //}

    //public TransportWaterRiverTram(string number)
    //{
    //    Number = number;
    //}

    //public TransportWaterRiverTram(string number, string destination) : this(number)
    //{
    //    Destination = destination;
    //}

    //public TransportWaterRiverTram(string number, string destination, int seatsNumber) : this(number, destination)
    //{
    //    SeatsNumber = seatsNumber;
    //}

    //public TransportWaterRiverTram(string number, string destination, int seatsNumber, DateTime departureTime) : this(number, destination, seatsNumber)
    //{
    //    DepartureTime = departureTime;
    //}

    public override string GetTransportInfo()
        {
            return (base.GetTransportInfo()
                + $"""
                
                Вид:    {TransportKind}

                Номер:              {Number}
                Пункт назначения:   {Destination}
                Время отправления   {DepartureTime}
                Число мест:         {SeatsNumber}
                {new string('~', 35)}
                """);
        }
    }
}
