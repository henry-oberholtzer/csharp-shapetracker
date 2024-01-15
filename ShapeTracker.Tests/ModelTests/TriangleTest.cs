using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleConstructor_CreateInstanceOfTriangle_Triangle()
        {
            Triangle newTriangle = new Triangle(3);
            Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
        }

        [TestMethod]
        public void GetSide1_ReturnsSide1_Int()
        {
            int length1 = 3;
            Triangle newTriangle = new Triangle(length1);
            int result = newTriangle.Side1;
            Assert.AreEqual(length1, result);
        }
    }
}
