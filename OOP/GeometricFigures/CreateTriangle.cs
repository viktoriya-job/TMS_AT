
namespace OOP.GeometricFigures
{
    internal class TriangleCreation
    {
        public Triangle CreateTriangleByType(float lengthSideA, float lengthSideB, float lengthSideC)
        {
            if (lengthSideA == lengthSideB && lengthSideA == lengthSideC)
                return new TriangleAllSidesEqual(lengthSideA);
            return new Triangle(lengthSideA, lengthSideB, lengthSideC);
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


