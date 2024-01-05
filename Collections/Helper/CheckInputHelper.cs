namespace Collections.Helper
{
    internal static class CheckInputHelper
    {
        public static bool IsCorrectInt32(string? input, out int value)
        {
            if (!String.IsNullOrWhiteSpace(input) && Int32.TryParse(input, out value))
            {
                return true;
            }

            Console.WriteLine("Введено некорректное значение - требуется целое число");
            ClearHelper.Exit();
            value = 0;
            return false;
        }

        public static bool IsCorrectSingle(string? input, out float value)
        {
            if (!String.IsNullOrWhiteSpace(input))
                if (Single.TryParse(input, out value))
                    return true;
            Console.WriteLine("Введено некорректное значение - требуется вещественное число");
            ClearHelper.Exit();
            value = 0;
            return false;
        }

        public static bool IsCorrectString(string? input)
        {
            if (!String.IsNullOrWhiteSpace(input))
                return true;
            Console.WriteLine("Введено пустое значение");
            ClearHelper.Exit();
            return false;
        }
    }
}
