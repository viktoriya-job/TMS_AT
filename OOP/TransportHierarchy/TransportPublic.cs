
namespace OOP.TransportHierarchy
{
    internal abstract class TransportPublic : Transport
    {
        protected string TransportTypeByTravelMedium { get; set; } = "Не определен";
        protected string TransportSubTypeByTravelMedium { get; set; } = "Не определен";
        protected string TransportKind { get; set; } = "Не определен";
        public string Number { get; set; } = "Не определен";
        public string Destination { get; set; } = "Не определен";
        private DateTime _departureTime = DateTime.Now;
        public DateTime DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                if (value < DateTime.Now)
                    Program.PrintRedText("Дата отправления не может быть задана прошлым числом");
                else
                    _departureTime = value;
            }
        }
        private int _seatsNumber = 1;
        public int SeatsNumber
        {
            get
            {
                return _seatsNumber;
            }
            set
            {
                if (value < 1)
                    Program.PrintRedText("Число мест должно быть больше 0");
                else
                    _seatsNumber = value;
            }
        }

        public TransportPublic()
        {
            TransportType = "Общественный транспорт";
        }

        public override string GetTransportType()
        {
            return $"{TransportType}: {TransportTypeByTravelMedium}: {TransportSubTypeByTravelMedium}: {TransportKind}";
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"""
                {new string('~', 45)}
                {TransportType}
                Тип:    {TransportSubTypeByTravelMedium} {TransportTypeByTravelMedium}
                Вид:    {TransportKind}

                Номер:              {Number}
                Пункт назначения:   {Destination}
                Время отправления   {DepartureTime}
                Число мест:         {SeatsNumber}
                {new string('~', 45)}
                """);
        }
    }
}