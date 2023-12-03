

namespace OOP.TransportHierarchy
{
    internal class TransportWaterRiverFerry : TransportWaterRiver
    {
        public string TransportKind { get; } = "Паром";
        public string Number { get; set; } = "Не установлен";
        public string Destination { get; set; } = "Не определен";

        DateTime departureTime = DateTime.Now;

        public DateTime DepartureTime
        {
            get
            {
                return departureTime;
            }
            set
            {
                if (value < DateTime.Now)
                    Console.WriteLine("Дата отправления не может быть меньше текущей");
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
                    Console.WriteLine("Число мест должно быть больше 0");
                else
                    seatsNumber = value;
            }
        }

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
