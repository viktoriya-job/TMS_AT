
namespace NUnitTest
{
    [TestFixture, Category("FunctionalTest")]
    public class CalcTests
    {
        private Calc _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calc();
        }

        [TestCase(1, 2, 0)]
        [TestCase(2, 2, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(-4, -2, 2)]
        [TestCase(-4, 4, -1)]
        [TestCase(-5, -2, 2)]
        [TestCase(5, -2, -2)]
        public void GivenCalcWhenIntDivThenCorrectValueReturned(int x, int y, int result)
        {
            Assert.That(_calc.Div(x, y), Is.EqualTo(result));
        }

        [TestCase(1, 2, 0.5)]
        [TestCase(2, 2, 1)]
        [TestCase(4.2, 2.1, 2)]
        [TestCase(-4, -2, 2)]
        [TestCase(-4, 4, -1)]
        [TestCase(-5, -2, 2.5)]
        [TestCase(5, -2, -2.5)]
        public void GivenCalcWhenDoubleDivThenCorrectValueReturned(double x, double y, double result)
        {
            Assert.That(_calc.Div(x, y), Is.EqualTo(result));
        }

        [Test]
        public void GivenCalcWhenDoubleDivWithZeroDividerThenException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Div(2d, 0));
        }

        [Test]
        public void GivenCalcWhenIntDivWithZeroDividerThenException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Div(2, 0));
        }
    }
}
