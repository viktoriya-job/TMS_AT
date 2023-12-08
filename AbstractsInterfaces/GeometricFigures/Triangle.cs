
namespace AbstractsInterfaces.GeometricFigures
{
    internal class Triangle : GeometricFigure
    {
        private float LengthSideA { get; set; }
        private float LengthSideB { get; set; }
        private float LengthSideC { get; set; }

        protected Triangle() { }
        public Triangle(float lengthSideA, float lengthSideB, float lengthSideC)
        {
            LengthSideA = lengthSideA;
            LengthSideB = lengthSideB;
            LengthSideC = lengthSideC;
        }

        public override float GetPerimeter() => LengthSideA + LengthSideB + LengthSideC;

        public override float GetArea()
        {
            float perimeterHalf = (LengthSideA + LengthSideB + LengthSideC) / 2;

            return Convert.ToSingle(
                        Math.Sqrt(perimeterHalf
                                * (perimeterHalf - LengthSideA)
                                * (perimeterHalf - LengthSideB)
                                * (perimeterHalf - LengthSideC)));
        }
    }
}
