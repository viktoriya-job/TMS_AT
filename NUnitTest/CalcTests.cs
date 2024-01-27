
namespace NUnitTest
{
    [TestFixture, Category("Functional"), Author("V. Aleksandrova", "viktoriya-job")]
    public class CalcTests
    {
        private Calc _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calc();
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideIntCases))]
        [Order(1)]
        [Category("PositiveTests")]
        [Category("IntValues")]
        [Severity(SeverityLevel.Critical)]
        public void CalcTestWhenIntDivThenCorrectValueReturned(int x, int y, int result)
        {
            Assert.That(_calc.Div(x, y), Is.EqualTo(result));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideDoubleCases))]
        [Order(1)]
        [Category("PositiveTests")]
        [Category("DoubleValues")]
        [Severity(SeverityLevel.Critical)]
        public void CalcTestWhenDoubleDivThenCorrectValueReturned(double x, double y, double result)
        {
            Assert.That(_calc.Div(x, y), Is.EqualTo(result));
        }

        [TestCase(1, 2, ExpectedResult = 0)]
        [TestCase(0, 2, ExpectedResult = 0)]
        [TestCase(21, -2, ExpectedResult = -10)]
        [Order(1)]
        [Category("PositiveTests")]
        [Category("IntValues")]
        [Severity(SeverityLevel.Major)]
        public int CalcTestWhenIntDivThenCorrectValueReturned(int x, int y)
        {
            return _calc.Div(x, y);
        }

        [TestCase(1, 2, 0.5)]
        [TestCase(0, 2.1, 0)]
        [TestCase(21, -2.5, -8.4)]
        [Order(1)]
        [Category("PositiveTests")]
        [Category("DoubleValues")]
        [Severity(SeverityLevel.Major)]
        public void CalcTestWhenDoubleDivThenCorrectValueReturned1(double x, double y, double result)
        {
            Assert.That(_calc.Div(x, y), Is.EqualTo(result));
        }

        [Test]
        [Description("Тест на проверку ошибки деления на ноль")]
        [Category("ErrorTests")]
        [Category("DoubleValues")]
        [Order(3)]
        [Severity(SeverityLevel.Major)]
        public void CalcTestWhenDoubleDivWithZeroDividerThenException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Div(2.0, 0));
        }

        [Test]
        [Description("Тест на проверку ошибки деления на ноль")]
        [Category("ErrorTests")]
        [Category("IntValues")]
        [Order(3)]
        [Severity(SeverityLevel.Major)]
        public void CalcTestWhenIntDivWithZeroDividerThenException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Div(2, 0));
        }

        [TestCase(1, 2, 0.5)]
        [Ignore("Пример использования атрибута Ignore")]
        public void CalcTestWhenDoubleDivThenCorrectValueReturned2(double x, double y, double result)
        {
            Assert.That(_calc.Div(x, y), Is.EqualTo(result));
        }
    }
}