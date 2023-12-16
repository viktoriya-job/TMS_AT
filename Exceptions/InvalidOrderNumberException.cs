
namespace Exceptions
{
    internal class InvalidOrderNumberException : Exception
    {
        public int Value { get; }
        public InvalidOrderNumberException(int value) : base(message: "Номер заказа не может быть отрицательным") => Value = value;
        public InvalidOrderNumberException(string message, int value) : base(message) => Value = value;
    }
}