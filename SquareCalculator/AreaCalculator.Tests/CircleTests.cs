using SquareCalculator;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        public void NegativeTest_Invalide_RadiusParameter_Should_Throw_Exception(double inputRadius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(inputRadius));
        }

        [TestCase(1, 3.1415926535897931)]
        [TestCase(20, 1256.6370614359173)]
        [TestCase(27, 2290.221044466959)]
        public void PositiveTest_CalculateArea_ReturnsArea(double inputRadius, double testArea)
        {
            var area = new Circle(inputRadius);
            Assert.That(area.Area, Is.EqualTo(testArea));
        }
    }
}