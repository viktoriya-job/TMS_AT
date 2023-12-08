
namespace AbstractsInterfaces.GeometricFigures
{
    internal class Rectangle : Triangle
    {
        private float LengthSideA { get; set; }
        private float LengthSideB { get; set; }

        protected Rectangle() { }
        public Rectangle(float lengthSideA, float lengthSideB)
        {
            LengthSideA = lengthSideA;
            LengthSideB = lengthSideB;
        }

        public override float GetPerimeter() => 2 * LengthSideA + 2 * LengthSideB;

        public override float GetArea() => LengthSideA * LengthSideB;
    }
}
