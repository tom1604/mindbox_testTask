namespace AreaCalculator
{
    public abstract class Figure
    {
        public double Area => _area.Value;

        private Lazy<double> _area;

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        protected abstract double CalculateArea();
    }
}