namespace Collections.Helper
{
    internal static class ClearHelper
    {
        public static void Exit()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
