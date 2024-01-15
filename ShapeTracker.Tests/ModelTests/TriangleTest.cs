using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleConstructor_CreateInstanceOfTriangle_Triangle()
        {
            Triangle newTriangle = new Triangle();
            Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
        }
    }
}
