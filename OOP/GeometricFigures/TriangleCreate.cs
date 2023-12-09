
namespace OOP.GeometricFigures
{
    internal class TriangleCreate
    {
        public static Triangle CreateTriangle(float lengthSideA, float lengthSideB, float lengthSideC)
        {
            if (lengthSideA == lengthSideB && lengthSideA == lengthSideC)
                return new TriangleAllSidesEqual(lengthSideA);

            else if (Math.Pow(lengthSideA, 2) == Math.Pow(lengthSideB, 2) + Math.Pow(lengthSideC, 2))
                return new TriangleRightAngle(lengthSideB, lengthSideC, lengthSideA);

            else if (Math.Pow(lengthSideB, 2) == Math.Pow(lengthSideA, 2) + Math.Pow(lengthSideC, 2))
                return new TriangleRightAngle(lengthSideA, lengthSideC, lengthSideB);

            else if (Math.Pow(lengthSideC, 2) == Math.Pow(lengthSideB, 2) + Math.Pow(lengthSideA, 2))
                return new TriangleRightAngle(lengthSideB, lengthSideA, lengthSideC);

            else if (lengthSideA == lengthSideB)
                return new TriangleTwoSidesEqual(lengthSideC,lengthSideA);

            else if (lengthSideA == lengthSideC)
                return new TriangleTwoSidesEqual(lengthSideB,lengthSideA);

            else if (lengthSideB == lengthSideC)
                return new TriangleTwoSidesEqual(lengthSideA, lengthSideB);

            return new TriangleSidesNotEqual(lengthSideA, lengthSideB, lengthSideC);
        }
    }
}