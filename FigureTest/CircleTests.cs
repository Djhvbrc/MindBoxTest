using FigureCalculation.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTest
{
    public class CircleTests
    {

        [Test]
        public void CircleRadius_5_ExceptionReturned()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Test]
        public void CircleSquareCalculate()
        {
            var circle = new Circle(6);

            Assert.That(circle.Square, Is.EqualTo(78.53981633974483));
        }
    }
}
