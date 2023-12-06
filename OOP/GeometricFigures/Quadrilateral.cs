

namespace OOP.GeometricFigures
{
    abstract class Quadrilateral : GeometricFigure
    {
        protected string QuadrilateralType { get; set; }

        protected Quadrilateral() => GeometricFigureType = "Четырехугольник";

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Вид: {QuadrilateralType} \nПлощадь: {GetArea()}");
        }
    }
}