
namespace OOP.GeometricFigures
{
    internal abstract class Quadrilateral : GeometricFigure
    {
        protected string QuadrilateralType { get; set; } = "Не определен";

        protected Quadrilateral() => GeometricFigureType = "Четырехугольник";

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Вид: {QuadrilateralType} \nПлощадь: {GetArea()}");
        }
    }
}