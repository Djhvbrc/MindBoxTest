using FigureCalculation.Figures.Base;

namespace FigureCalculation.Figures
{
    public class Triangle: Figure
    {
        private List<double> _sidesList = new();
        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
                throw new ArgumentException("Неверно указана сторона A");

            if (sideB <= 0)
                throw new ArgumentException("Неверно указана сторона B");

            if (sideC <= 0)
                throw new ArgumentException("Неверно указана сторона C");
            _sidesList.Add(sideA);
            _sidesList.Add(sideB);
            _sidesList.Add(sideC);

            _isRightTriangle = new Lazy<bool>(CheckIfTriangleIsRight);
            ValidateFigure();
        }
        protected override void ValidateFigure()
        {
            if (!(_sidesList[0] < _sidesList[1] + _sidesList[2] 
                  && _sidesList[1] < _sidesList[0] + _sidesList[2] 
                  && _sidesList[2] < _sidesList[0] + _sidesList[1]))
                throw new ArgumentException("Треугольник с такими сторонами не может существовать");
        }

        private bool CheckIfTriangleIsRight()
        {
            _sidesList = _sidesList.OrderBy(s => s).ToList();
            return Math.Abs(Math.Pow(_sidesList[2], 2) - (Math.Pow(_sidesList[0], 2) + Math.Pow(_sidesList[1], 2))) == 0;
        }

        protected override double CalculateSquare()
        {
            var semiPerimeter = _sidesList.Sum(s => s) * 0.5;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sidesList[0]) * (semiPerimeter - _sidesList[1]) *
                             (semiPerimeter - _sidesList[2]));
        }
    }
}
