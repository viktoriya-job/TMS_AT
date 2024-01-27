namespace NUnitTest
{
    public class TestData
    {
        public static object[] DivideIntCases =
        {
        new object[] { 4, 2, 2 },
        new object[] { 2, 2, 1 },
        new object[] { -13, -2, 6 },
        new object[] { -10, 4, -2 }
        };

        public static object[] DivideDoubleCases =
{
        new object[] { 4.2, 2.1, 2 },
        new object[] { 2, 2, 1 },
        new object[] { -13, -2, 6.5 },
        new object[] { -10, 4, -2.5 }
        };
    }
}