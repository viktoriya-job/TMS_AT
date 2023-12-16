
namespace Exceptions
{
    internal class EmptyOrderException : Exception
    {
        public EmptyOrderException() : base(message: "Список товаров не может быть пустым") { }
        public EmptyOrderException(string message) : base(message) { }
    }
}