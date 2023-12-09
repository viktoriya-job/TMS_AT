
namespace OOP.TransportHierarchy
{
    internal abstract class TransportPersonal : Transport
    {
        protected string TransportPersonalKind { get; set; } = "Не определен";
        public string Color { get; set; } = "Не определен";
        private DateOnly _purchaseDate = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly PurchaseDate
        {
            get
            {
                return _purchaseDate;
            }
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Now))
                    Program.PrintRedText("Дата покупки не может быть задана будущим числом");
                else
                    _purchaseDate = value;
            }
        }

        public TransportPersonal() => TransportType = "Личный транспорт";

        public override string GetTransportType()
        {
            return $"{TransportType}: {TransportPersonalKind}";
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{ TransportType}: { TransportPersonalKind}\nДата покупки: { PurchaseDate}");
        }
    }
}
