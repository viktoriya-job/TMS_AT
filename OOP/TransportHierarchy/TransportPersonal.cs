
namespace OOP.TransportHierarchy
{
    internal abstract class TransportPersonal : Transport
    {
        protected string TransportPersonalKind { get; set; } = "Не определен";
        public string Color { get; set; } = "Не определен";
        private DateTime _purchaseDate = DateTime.Now;
        public DateTime PurchaseDate
        {
            get
            {
                return _purchaseDate;
            }
            set
            {
                if (value > DateTime.Now)
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
