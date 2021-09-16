using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;

namespace TestProject
{
    [TestClass]
    public class SqTests
    {
        [TestMethod]
        public void Circle_Rad1_Ret628()
        {
            double radius   = 1.0;
            double expected = 6.28;
            double actual   = Square.Square.GetSquare(radius);
            double delta    = 0.005;

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Triangle345_Ret6()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expected = 6.0;
            double actual = Square.Square.GetSquare(a, b, c);
            double delta = 0.005;

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Triangle6810_isright()
        {
            double a = 6.0;
            double b = 8.0;
            double c = 10.0;

            Square.Square.GetSquare(a, b, c);

            bool actual = Square.Square.TriangleIsRight;

            Assert.IsTrue(actual);
        }
    }
}
