
namespace Exceptions
{
    internal class Order
    {
        private int _number;
        private List<string> _products = new List<string>();
        private string _deliveryAddress = String.Empty;
        public int Number
        {
            get => _number;
            set
            {
                if (value < 0)
                    throw new InvalidOrderNumberException(value);
                _number = value;
            }
        }
        public List<string> Products
        {
            get => _products;
            set
            {
                if (value.Count == 0)// (value.Capacity == 0)
                    throw new EmptyOrderException();
                _products = value;
            }
        }
        public string DeliveryAddress
        {
            get => _deliveryAddress;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new DeliveryInformationMissingException();
                _deliveryAddress = value;
            }
        }

        public Order(int number, List<string> products, string deliveryAddress)
        {
            Number = number;
            Products = products;
            DeliveryAddress = deliveryAddress;
        }

        public void PrintProductsList()
        {
            foreach (var item in Products)
                Console.WriteLine($"    - {item}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"""
                {new string('~', 25)}
                Номер заказа:   {Number}
                Адрес доставки: {DeliveryAddress}
                Список товаров:
                """);
            PrintProductsList();
        }
    }
}
