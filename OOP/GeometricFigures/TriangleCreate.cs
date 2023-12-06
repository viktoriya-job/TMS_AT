
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
    




    //    internal class TriangleCreation : GeometricFigure
    //    {
    //        public float LengthSideA { get; set; }
    //        public float LengthSideB { get; set; }
    //        public float LengthSideC { get; set; }

    //                    if (lengthSideA == lengthSideB && lengthSideA == lengthSideC)
    //            {
    //                ArmsEquality = "Равносторонний треугольник";
    //                return new TriangleAllSidesEqual(lengthSideA, lengthSideB, lengthSideC);
    //    }

    //    public TriangleCreation(float lengthSideA, float lengthSideB, float lengthSideC)
    //    {
    //        LengthSideA = lengthSideA;
    //        LengthSideB = lengthSideB;
    //        LengthSideC = lengthSideC;
    //        ArmsEquality = "Разносторонний треугольник";
    //    }

    //    public Triangle CreateTriangle(float lengthSideA, float lengthSideB, float lengthSideC)
    //    {
    //        if (lengthSideA == lengthSideB && lengthSideA == lengthSideC)
    //        {
    //            ArmsEquality = "Равносторонний треугольник";
    //            return new TriangleAllSidesEqual(lengthSideA, lengthSideB, lengthSideC);
    //        }

    //        else if (lengthSideA == lengthSideB || lengthSideA == lengthSideC || lengthSideB == lengthSideC)
    //        {
    //            return new TriangleTwoSidesEqual(lengthSideA, lengthSideB, lengthSideC);
    //        }

    //        else if ((Math.Pow(LengthSideA, 2) == Math.Pow(LengthSideB, 2) + Math.Pow(LengthSideC, 2))
    //            || (Math.Pow(LengthSideC, 2) == Math.Pow(LengthSideA, 2) + Math.Pow(LengthSideB, 2))
    //            || (Math.Pow(LengthSideB, 2) == Math.Pow(LengthSideC, 2) + Math.Pow(LengthSideA, 2)))
    //        {
    //            return new TriangleRightAngle(lengthSideA, lengthSideB, lengthSideC);
    //        }

    //        else
    //            return new Triangle(lengthSideA, lengthSideB, lengthSideC);
    //    }
    //}
    //}


