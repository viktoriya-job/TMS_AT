namespace Generics.Helper
{
    internal class PrintHelper
    {
        public static void PrintRedText(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintArray<T>(T[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]} ");
            }
            Console.WriteLine();
        }
    }
}