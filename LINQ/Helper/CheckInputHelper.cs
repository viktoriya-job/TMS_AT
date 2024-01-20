namespace LINQ.Helper
{
    internal static class CheckInputHelper
    {
        public static bool IsCorrectInt32(string? input, out int value)
        {
            if (!String.IsNullOrWhiteSpace(input))
                if (Int32.TryParse(input, out value))
                    return true;
            Console.WriteLine("Введено некорректное значение - требуется целое число");
            value = 0;
            return false;
        }
    }
}
