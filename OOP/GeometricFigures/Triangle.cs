
namespace OOP.GeometricFigures
{
    internal abstract class Triangle : GeometricFigure
    {
        protected string TriangleType { get; set; } = "Не определен";

        protected Triangle() => GeometricFigureType = "Треугольник";

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Вид: {TriangleType} \nПлощадь: {GetArea()}");
        }
    }
}