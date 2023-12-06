
namespace OOP.GeometricFigures
{
    internal class TriangleSidesNotEqual : Triangle
    {
        public float LengthSideA { get; set; }
        public float LengthSideB { get; set; }
        public float LengthSideC { get; set; }

        public TriangleSidesNotEqual(float lengthSideA, float lengthSideB, float lengthSideC)
        {
            LengthSideA = lengthSideA;
            LengthSideB = lengthSideB;
            LengthSideC = lengthSideC;
            TriangleType = "Разносторонний треугольник";
        }

        public override float GetArea()
        {
            float perimeterHalf = (LengthSideA + LengthSideB + LengthSideC) / 2;

            return Convert.ToSingle(
                        Math.Sqrt(perimeterHalf
                                * (perimeterHalf - LengthSideA)
                                * (perimeterHalf - LengthSideB)
                                * (perimeterHalf - LengthSideC)));
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Стороны: {LengthSideA}, {LengthSideB}, {LengthSideC}\n");
        }
    }
}
