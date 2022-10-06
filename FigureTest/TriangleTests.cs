using FigureCalculation.Figures;

namespace FigureTest
{
    public class TriangleTests
    {

        [Test]
        public void TriangleSquare_3and4and5_6returned()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.That(triangle.Square, Is.EqualTo(6));
        }

        [Test]
        public void TriangleIsRightTriangle_3and6and8_FalseReturned()
        {
            var triangle = new Triangle(3, 6, 8);

            Assert.That(triangle.IsRightTriangle, Is.EqualTo(false));
        }

        [Test]
        public void TriangleIsRightTriangle_3and5and4_TrueReturned()
        {
            var triangle = new Triangle(3, 5, 4);

            Assert.That(triangle.IsRightTriangle, Is.EqualTo(true));
        }

        [Test]
        public void Triangle_minus1_2_4_ExceptionReturned()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(-1, 2, 4));
        }
    }
}