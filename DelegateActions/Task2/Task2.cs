namespace Delegate
{
    internal class Task2
    {
        public delegate double CalcByRadius(double radius);

        public void Run()
        {
            double radius = 5;
            Calc calc = new Calc();
            
            CalcByRadius calcCirclePerimeter = calc.CalcCirclePerimeter;
            CalcByRadius calcCircleArea = calc.CalcCircleArea;
            CalcByRadius calcBallVolume = calc.CalcBallVolume;

            Console.WriteLine($"Длина окружности с радиусом {radius}: {calcCirclePerimeter(radius)}");
            Console.WriteLine($"Площадь круга с радиусом {radius}: {calcCircleArea(radius)}");
            Console.WriteLine($"Объем шара с радиусом {radius}: {calcBallVolume(radius)}");
        }
    }
}
