using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureCalculation.Figures.Base;

namespace FigureCalculation.Figures
{
    public class Circle: Figure
    {
        private double _radius { get; }
        public Circle(double radius)
        {
            _radius = radius;
            ValidateFigure();
        }
        protected override void ValidateFigure()
        {
            if (_radius <= 0) 
                throw new ArgumentException("Радиус не может быть меньше или равен нулю");
        }

        protected override double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
