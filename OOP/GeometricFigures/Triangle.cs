
namespace OOP.GeometricFigures
{
    internal class Triangle : GeometricFigure
    {
        public float LengthSideA { get; set; }
        public float LengthSideB { get; set; }
        public float LengthSideC { get; set; }

        public Triangle(float lengthSideA, float lengthSideB, float lengthSideC)
        {
            LengthSideA = lengthSideA;
            LengthSideB = lengthSideB;
            LengthSideC = lengthSideC;
        }

        public virtual float TriangleArea()
        {
            float perimeterHalf = (LengthSideA + LengthSideB + LengthSideC) / 2;
            return Convert.ToSingle(
                        Math.Sqrt(perimeterHalf
                                * (perimeterHalf - LengthSideA)
                                * (perimeterHalf - LengthSideB)
                                * (perimeterHalf - LengthSideC)));
        }
    }

    internal class TriangleTwoSidesEqual : Triangle
    {
        public TriangleTwoSidesEqual(float lengthSideA, float lengthSideB) : base(lengthSideA, lengthSideA, lengthSideB) { }

        public override float TriangleArea()
        {
            float triangleBase = LengthSideA;
            float triangleEqualSide = LengthSideB;

            if (LengthSideA == LengthSideB)
            {
                triangleBase = LengthSideC;
            }
            else if (LengthSideA == LengthSideC)
            {
                triangleBase = LengthSideB;
                triangleEqualSide = LengthSideA;
            }

            float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(triangleEqualSide, 2)
                                         - Math.Pow(Convert.ToSingle(triangleBase) / 2, 2)));
            return TriangleHeight * triangleBase / 2;
        }
    }

    internal class TriangleAllSidesEqual : TriangleTwoSidesEqual
    {
        public TriangleAllSidesEqual(float lengthSideA) : base(lengthSideA, lengthSideA)
        {
        }

        public override float TriangleArea()
        {
            float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(LengthSideA, 2)
                             - Math.Pow(Convert.ToSingle(LengthSideA) / 2, 2)));
            return TriangleHeight * LengthSideA / 2;
        }
    }
}


















    //internal class TriangleAllSidesEqual: GeometricFigure
    //{
    //    public float LengthSideA { get; set; }

    //    public TriangleAllSidesEqual(float lengthSideA)
    //    {
    //        LengthSideA = lengthSideA;
    //    }

    //    public virtual float TriangleArea()
    //    {
    //        float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(LengthSideA, 2)
    //                         - Math.Pow(Convert.ToSingle(LengthSideA) / 2, 2)));
    //        return TriangleHeight * LengthSideA / 2;
    //    }
    //}

    //internal class TriangleTwoSidesEqual : TriangleAllSidesEqual
    //{
    //    public float LengthSideB { get; set; }

    //    public TriangleTwoSidesEqual(float lengthSideA, float lengthSideB) : base(lengthSideA)
    //    {
    //        LengthSideB = lengthSideB;
    //    }

    //    public override float TriangleArea()
    //    {
    //        float triangleBase = LengthSideA;
    //        float triangleEqualSide = LengthSideB;

    //        float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(triangleEqualSide, 2)
    //                                     - Math.Pow(Convert.ToSingle(triangleBase) / 2, 2)));
    //        return TriangleHeight * triangleBase / 2;
    //    }
    //}


















    //internal class Triangle : GeometricFigure
    //{
    //    public float LengthSideA { get; set; }
    //    public float LengthSideB { get; set; }
    //    public float LengthSideC { get; set; }

    //    public Triangle(float lengthSideA, float lengthSideB, float lengthSideC)
    //    {
    //        LengthSideA = lengthSideA;
    //        LengthSideB = lengthSideB;
    //        LengthSideC = lengthSideC;
    //        ArmsEquality = "Разносторонний треугольник";
    //    }

    //    public virtual float TriangleArea()
    //    {
    //        float perimeterHalf = (LengthSideA + LengthSideB + LengthSideC) / 2;
    //        return Convert.ToSingle(
    //                    Math.Sqrt(perimeterHalf
    //                            * (perimeterHalf - LengthSideA)
    //                            * (perimeterHalf - LengthSideB)
    //                            * (perimeterHalf - LengthSideC)));
    //    }
    //}

    //internal class TriangleTwoSidesEqual : Triangle
    //{
    //    public TriangleTwoSidesEqual(float lengthSideA, float lengthSideB, float lengthSideC) : base(lengthSideA, lengthSideB, lengthSideC) 
    //    {
    //        ArmsEquality = "Равнобедренный треугольник";
    //    }

    //    public override float TriangleArea()
    //    {
    //        float triangleBase = LengthSideA;
    //        float triangleEqualSide = LengthSideB;

    //        if (LengthSideA == LengthSideB)
    //        {
    //            triangleBase = LengthSideC;
    //        }
    //        else if (LengthSideA == LengthSideC)
    //        {
    //            triangleBase = LengthSideB;
    //            triangleEqualSide = LengthSideA;
    //        }

    //        float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(triangleEqualSide, 2)
    //                                     - Math.Pow(Convert.ToSingle(triangleBase) / 2, 2)));
    //        return TriangleHeight * triangleBase / 2;
    //    }
    //}

    //internal class TriangleAllSidesEqual : Triangle
    //{
    //    public TriangleAllSidesEqual(float lengthSideA, float lengthSideB, float lengthSideC) : base(lengthSideA, lengthSideB, lengthSideC) 
    //    {
    //        ArmsEquality = "Равносторонний треугольник";
    //    }

    //    public override float TriangleArea()
    //    {
    //        float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(LengthSideA, 2)
    //                         - Math.Pow(Convert.ToSingle(LengthSideA) / 2, 2)));
    //        return TriangleHeight * LengthSideA / 2;
    //    }
    //}



    //internal class TriangleRightAngle : Triangle
    //{
    //    public TriangleRightAngle(float lengthSideA, float lengthSideB, float lengthSideC) : base(lengthSideA, lengthSideB, lengthSideC) 
    //    { 
    //                ArmsEquality = "Прямоугольный треугольник";
    //    }

    //    public override float TriangleArea()
    //    {
    //        float leg1 = LengthSideA;
    //        float leg2 = LengthSideB;

    //        if (Math.Pow(LengthSideA,2) == Math.Pow(LengthSideB,2) + Math.Pow(LengthSideC, 2))
    //            leg1 = LengthSideC;
    //        else if (Math.Pow(LengthSideB, 2) == Math.Pow(LengthSideA, 2) + Math.Pow(LengthSideC, 2))
    //            leg2 = LengthSideC;

    //        return leg1 * leg2 / 2;
    //    }
    //}


