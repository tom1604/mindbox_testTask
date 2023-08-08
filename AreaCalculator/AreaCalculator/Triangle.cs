namespace AreaCalculator
{
    public class Triangle : Figure
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRightTriangle => _isRightTriangle.Value;

        private Lazy<bool> _isRightTriangle;

        /// <summary>
        ///  Triangle
        /// </summary>
        /// <param name="firstSide">First side</param>
        /// <param name="secondSide">Second side</param>
        /// <param name="thirdSide">Third side</param>
        /// <exception cref="ArgumentOutOfRangeException">If the side of the triangle is negative or equal to 0</exception>
        /// <exception cref="ArgumentException">
        /// If the sides of a triangle do not satisfy the theorem: 
        /// Each side of a triangle is less than the sum of its other two sides
        /// </exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException("Sides of Triangle cannot be negative or are 0");
            if (firstSide + secondSide < thirdSide || secondSide + thirdSide < firstSide || firstSide + thirdSide < secondSide)
                throw new ArgumentException("Provided sides do not form a triangle");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightTriangle = new Lazy<bool>(CheckIsRightTriangle);
        }

        /// <summary>
        /// Checking the rectangularity of a triangle using the Pythagorean theorem
        /// </summary>
        private bool CheckIsRightTriangle()
        {
            var sides = new List<double>() { FirstSide, SecondSide, ThirdSide };
            sides.Sort();
            return Math.Pow(sides.Last(), 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        /// <summary>
        /// Calculate the area of ​​a triangle according to Heron's formula
        /// </summary>
        protected override double CalculateArea()
        {
            var perimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(perimeter * (perimeter - FirstSide) * (perimeter - SecondSide) * (perimeter - ThirdSide));
        }
    }
}
