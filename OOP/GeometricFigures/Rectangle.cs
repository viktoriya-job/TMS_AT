
namespace OOP.GeometricFigures
{

    internal class Square : GeometricFigure
    {
        public int LengthSideA { get; set; }

        public Square(int lengthSide)
        {
            LengthSideA = lengthSide;
        }

        public virtual int RectangleArea() => LengthSideA * LengthSideA;
    }

    internal class Rectangle : Square
    {
        public int LengthSideB { get; set; }

        public Rectangle(int lengthSideA, int lengthSideB): base(lengthSideA)
        {
            LengthSideB = lengthSideB;
        }

        public override int RectangleArea() => LengthSideA * LengthSideB;
    }
}
