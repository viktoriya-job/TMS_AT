
namespace OOP.GeometricFigures
{
    internal class Rectangle : Quadrilateral
    {
        public float LengthSideA { get; set; }
        public float LengthSideB { get; set; }

        public Rectangle(float lengthSideA, float lengthSideB)
        {
            LengthSideA = lengthSideA;
            LengthSideB = lengthSideB;
            QuadrilateralType = "Прямоугольник";
        }

        public override float GetArea() => LengthSideA * LengthSideB;

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Стороны прямоугольника: {LengthSideA}, {LengthSideB}\n");
        }
    }
}
