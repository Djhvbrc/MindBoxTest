using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureCalculation.Figures.Base;

namespace FigureCalculation.Strategy
{
    public class FigureStrategy
    {
        private Figure _figure;

        public FigureStrategy()
        { }

        public FigureStrategy(Figure figure)
        {
            _figure = figure;
        }

        public void SetFigureStrategy(Figure figure)
        {
            _figure = figure;
        }

        public double CalculateSquare() => _figure.Square;

    }
}
