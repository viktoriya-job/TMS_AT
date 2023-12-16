
namespace Exceptions
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException() { }

        public WrongLoginException(string? message) : base(message) { }

    }
}
