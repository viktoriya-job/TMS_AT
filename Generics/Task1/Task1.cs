using Generics.Helper;

namespace Generics
{
    internal class Task1
    {
        public static void Run()
        {
            Random random = new Random();
            Point<int> pointInt = new Point<int>(random.Next(10), random.Next(10));
            Point<double> pointFloat = new Point<double>(random.NextDouble(), random.NextDouble());

            PrintHelper.PrintRedText("Вывод информации по координатам точек");

            pointInt.PrintValues();
            pointFloat.PrintValues();
        }
    }
}