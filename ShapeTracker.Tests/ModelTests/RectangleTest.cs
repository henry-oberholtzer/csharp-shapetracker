using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class RectangleTests : IDisposable
    {
        public void Dispose()
        {
            Rectangle.ClearAll();
        }

        [TestMethod]
        public void RectangleConstructor_CreateInstanceOfRectangle_Rectangle()
        {
            Rectangle newRectangle = new Rectangle(3, 6);
            Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
        }

        [TestMethod]
        public void GetWidth_ReturnsWidth_Int()
        {
            int width = 3;
            Rectangle newRectangle = new Rectangle(width, 8);
            Assert.AreEqual(width, newRectangle.Width);
        }

        [TestMethod]
        public void SetWidth_SetsValueOfWidth_Void()
        {
            Rectangle newRectangle = new Rectangle(3, 6);
            int newWidth = 34;
            newRectangle.Width = newWidth;
            Assert.AreEqual(newWidth, newRectangle.Width);
        }

        [TestMethod]
        public void GetHeight_ReturnsHeight_Int()
        {
            int height = 3;
            Rectangle newRectangle = new Rectangle(2, height);
            Assert.AreEqual(height, newRectangle.Height);
        }

        [TestMethod]
        public void SetHeight_SetsValueOfHeight_Void()
        {
            Rectangle newRectangle = new Rectangle(4, 3);
            int newHeight = 5;
            newRectangle.Height = newHeight;
            Assert.AreEqual(newHeight, newRectangle.Height);
        }

        [TestMethod]
        public void ComputeArea_Calculate_Int()
        {
            Rectangle rectangle10 = new Rectangle(2, 5);
            int area = rectangle10.ComputeArea();
            Assert.AreEqual(10, area);
        }

        [TestMethod]
        public void GetAll_ReturnsAllRectangleInstances_List()
        {
            Rectangle one = new Rectangle(2, 3);
            Rectangle two = new Rectangle(4, 5);
            Rectangle three = new Rectangle(5, 6);
            List<Rectangle> expected = new List<Rectangle> { one, two, three };
            List<Rectangle> actual = Rectangle.GetAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClearAll_ClearsAllRectangleInstances_Void()
        {
            Rectangle one = new Rectangle(2, 3);
            Rectangle two = new Rectangle(4, 5);
            Rectangle three = new Rectangle(5, 6);
            List<Rectangle> expected = new List<Rectangle> { };
            Rectangle.ClearAll();
            CollectionAssert.AreEqual(expected, Rectangle.GetAll());
        }
    }
}
