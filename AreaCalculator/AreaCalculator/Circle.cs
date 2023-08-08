namespace AreaCalculator
{
    public class Circle : Figure
    {
        public double Radius { get; }

        /// <summary>
        ///  Circle
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <exception cref="ArgumentOutOfRangeException">If the side of the triangle is negative or equal to 0</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius cannot be negative or is 0");

            Radius = radius;
        }

        /// <summary>
        /// Calculate Circle area in terms of radius
        /// </summary>
        protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
