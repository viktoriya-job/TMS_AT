
namespace OOP.GeometricFigures
{
    abstract class Triangle : GeometricFigure
    {
        protected string TriangleType { get; set; }

        protected Triangle() => GeometricFigureType = "Треугольник";

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Вид: {TriangleType} \nПлощадь: {GetArea()}");
        }
    }
}