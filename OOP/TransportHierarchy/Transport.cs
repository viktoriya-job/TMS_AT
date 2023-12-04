
namespace OOP.TransportHierarchy
{
    internal class Transport
    {
        public string TransportType { get; set; } = "Транспорт";

        public string TransportSubType { get; set; } = "Не определен";

        public string TransportKind { get; set; } = "Не определен";

        public string Number { get; set; } = "Не установлен";

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
                    Program.PrintRedText("Дата отправления не может быть меньше текущей");
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
        public Transport() { }

        public virtual string GetTransportInfo() => TransportType;

        public string PrintTransportInfo(char symbol)
        {
            return($"""
                {new string(symbol, 45)}
                Тип:    {TransportSubType} {TransportType}
                Вид:    {TransportKind}

                Номер:              {Number}
                Пункт назначения:   {Destination}
                Время отправления   {DepartureTime}
                Число мест:         {SeatsNumber}
                {new string(symbol, 45)}
                """);
        }

        // "Определить метод в суперклассе, который нельзя будет переопределить
        // в классах наследниках и запретить это переопределение"
        //
        //Следующий метод нельзя переопределить, так как он не virtual / abstract
        //sead здесь не подходит, так как используется, если метод уже override
        public string GetTransportSubType() => TransportSubType;
    }
}
