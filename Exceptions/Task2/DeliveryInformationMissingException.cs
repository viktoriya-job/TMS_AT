
namespace Exceptions
{
    internal class DeliveryInformationMissingException : Exception
    {
        public DeliveryInformationMissingException(): base(message: "Отсутствуют данные для доставки") { }
        public DeliveryInformationMissingException(string message) : base(message) { }
    }
}