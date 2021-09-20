using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SqureFigure;


namespace TestFigureSquare
{
    [TestClass]
    public class UnitTest1
    {
        Figure fgr = new Figure();
        [TestMethod]
        public void TestCircle()
        {
            double res = fgr.Cirlce(5);
            double test_res = Math.PI * 5 * 5;
            Assert.AreEqual(test_res, res);
        }
        [TestMethod]
        public void TestTriangle()
        {
            double res = fgr.Triangle(2,2,3);
            double test_res = 1.9843;
            Assert.AreEqual(res, test_res, .0001);
        }
        [TestMethod]
        public void TestTriangle2()
        {
            double res = fgr.Triangle(3, 4, 5);
            double test_res = 6;
            Assert.AreEqual(res, test_res);
        }
    }
}
