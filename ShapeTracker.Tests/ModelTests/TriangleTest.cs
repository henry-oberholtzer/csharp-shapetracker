using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleConstructor_CreateInstanceOfTriangle_Triangle()
        {
            Triangle newTriangle = new Triangle(3, 6);
            Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
        }

        [TestMethod]
        public void GetSide1_ReturnsSide1_Int()
        {
            // Arrange
            int length1 = 3;
            Triangle newTriangle = new Triangle(length1, 8);
            Assert.AreEqual(length1, newTriangle.Side1);
        }

        [TestMethod]
        public void SetSide1_SetsValueOfSide1_Void()
        {
            Triangle newTriangle = new Triangle(3, 6);
            int newLength = 34;
            newTriangle.Side1 = newLength;
            Assert.AreEqual(newLength, newTriangle.Side1);
        }

        [TestMethod]
        public void GetSide2_ReturnsSide2_Int()
        {
            int length2 = 3;
            Triangle newTriangle = new Triangle(2, length2);
            Assert.AreEqual(length2, newTriangle.Side2);
        }

        [TestMethod]
        public void SetSide2_SetsValueOfSide2_Void()
        {
            Triangle newTriangle = new Triangle(4, 3);
            int newSide2 = 5;
            newTriangle.Side2 = newSide2;
            Assert.AreEqual(newSide2, newTriangle.Side2);
        }
    }
}
