
namespace OOP.GeometricFigures
{
    internal class TriangleAllSidesEqual : Triangle
    {
        public float LengthSide { get; set; }

        public TriangleAllSidesEqual(float lengthSide)
        {
            LengthSide = lengthSide;
            TriangleType = "Равносторонний треугольник";
        }

        public override float GetArea()
        {
            return (float)(Math.Sqrt(3) / 4 * LengthSide * LengthSide);
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Стороны: {LengthSide}, {LengthSide}, {LengthSide}\n");
        }
    }
}
