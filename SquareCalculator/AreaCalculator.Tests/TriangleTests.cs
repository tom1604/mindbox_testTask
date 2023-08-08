using SquareCalculator;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 0, 1)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(-2, 2, 4)]
        [TestCase(-1, -1, -1)]
        [TestCase(2, 2, -4)]
        [TestCase(2, -2, 4)]
        [TestCase(-1, 0, 3)]
        public void NegativeTest_NegativeOrZeroParameters_Should_Throw_Exception(double inputFirstSide, double inputSecondSide, double inputThirdSide)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(inputFirstSide, inputSecondSide, inputThirdSide));
        }

        [TestCase(2, 1, 5)]
        [TestCase(5, 2, 1)]
        public void NegativeTest_InvalidParameters_Should_Throw_Exception(double inputFirstSide, double inputSecondSide, double inputThirdSide)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(inputFirstSide, inputSecondSide, inputThirdSide));
        }


        [TestCase(2, 1, 3, 0)]
        [TestCase(40, 20, 40, 387.2983346207417)]
        public void PositiveTest_CalculateArea_ReturnsArea(double inputFirstSide, double inputSecondSide, double inputThirdSide, double testArea)
        {
            var area = new Triangle(inputFirstSide, inputSecondSide, inputThirdSide);
            Assert.That(area.Area, Is.EqualTo(testArea));
        }

        [TestCase(2, 1, 3, false)]
        [TestCase(40, 20, 40, false)]
        [TestCase(3, 4, 5, true)]
        public void PositiveTest_CheckIsRightTriangle(double inputFirstSide, double inputSecondSide, double inputThirdSide, bool testValue)
        {
            var area = new Triangle(inputFirstSide, inputSecondSide, inputThirdSide);
            Assert.That(testValue, Is.EqualTo(area.IsRightTriangle));
        }
    }
}
