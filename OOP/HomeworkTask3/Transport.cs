
namespace OOP.TransportHierarchy
{
    internal class Transport
    {
        public string TransportType { get; set; } = "Транспорт";

        public string TransportSubType { get; set; } = "Не определен";

        public string TransportKind { get; set; } = "Не определен";

        public string Number { get; set; } = "Не установлен";

        public string Destination { get; set; } = "Не определен";

        public DateTime departureTime = DateTime.Now;

        public DateTime DepartureTime
        {
            get
            {
                return departureTime;
            }
            set
            {
                if (value < DateTime.Now)
                    PrintRedText("Дата отправления не может быть меньше текущей");
                else
                    departureTime = value;
            }
        }

        int seatsNumber = 1;
        public int SeatsNumber
        {
            get
            {
                return seatsNumber;
            }
            set
            {
                if (value < 1)
                    PrintRedText("Число мест должно быть больше 0");
                else
                    seatsNumber = value;
            }
        }
        public Transport() { }

        public virtual string  GetTransportInfo() => TransportType;

        public static void PrintRedText(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
