using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class TriangleTests : IDisposable
    {
        public void Dispose()
        {
            Triangle.ClearAll();
        }

        [TestMethod]
        public void TriangleConstructor_CreateInstanceOfTriangle_Triangle()
        {
            Triangle newTriangle = new Triangle(3, 6, 4);
            Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
        }

        [TestMethod]
        public void GetSide1_ReturnsSide1_Int()
        {
            // Arrange
            int length1 = 3;
            Triangle newTriangle = new Triangle(length1, 8, 8);
            Assert.AreEqual(length1, newTriangle.Side1);
        }

        [TestMethod]
        public void SetSide1_SetsValueOfSide1_Void()
        {
            Triangle newTriangle = new Triangle(3, 6, 6);
            int newLength = 34;
            newTriangle.Side1 = newLength;
            Assert.AreEqual(newLength, newTriangle.Side1);
        }

        [TestMethod]
        public void GetSide2_ReturnsSide2_Int()
        {
            int length2 = 3;
            Triangle newTriangle = new Triangle(2, length2, 5);
            Assert.AreEqual(length2, newTriangle.Side2);
        }

        [TestMethod]
        public void SetSide2_SetsValueOfSide2_Void()
        {
            Triangle newTriangle = new Triangle(4, 3, 5);
            int newSide2 = 5;
            newTriangle.Side2 = newSide2;
            Assert.AreEqual(newSide2, newTriangle.Side2);
        }

        [TestMethod]
        public void GetSide3_ReturnsSide3_Int()
        {
            int length3 = 3;
            Triangle newTriangle = new Triangle(4, 5, length3);
            Assert.AreEqual(length3, newTriangle.Side3);
        }

        [TestMethod]
        public void SetSide3_SetsValueofSide3_Void()
        {
            Triangle newTriangle = new Triangle(1, 2, 3);
            int newLength3 = 4;
            newTriangle.Side3 = newLength3;
            Assert.AreEqual(newLength3, newTriangle.Side3);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenNotATriangle_String()
        {
            Triangle notATriangle = new Triangle(3, 4, 88);
            string triType = notATriangle.CheckType();
            Assert.AreEqual("not a triangle", triType);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenScalene_String()
        {
            Triangle scaleneTri = new Triangle(3, 4, 5);
            string triType = scaleneTri.CheckType();
            Assert.AreEqual("a scalene triangle", triType);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenEquilateral_String()
        {
            Triangle tri = new Triangle(6, 6, 6);
            string type = tri.CheckType();
            Assert.AreEqual("an equilateral triangle", type);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenIsosceles_String()
        {
            Triangle isoTri = new Triangle(5, 4, 4);
            string triType = isoTri.CheckType();
            Assert.AreEqual("an isosceles triangle", triType);
        }

        [TestMethod]
        public void GetAll_ReturnsAllTriangleInstances_List()
        {
            // Arrange
            Triangle tri1 = new Triangle(2, 2, 9);
            Triangle tri2 = new Triangle(21, 3, 9);
            Triangle tri3 = new Triangle(1, 3, 9);
            List<Triangle> expected = new List<Triangle> { tri1, tri2, tri3 };
            // Act
            List<Triangle> actualResult = Triangle.GetAll();
            // Assert
            CollectionAssert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void ClearAll_DeletesAllTrianglesInList_Void()
        {
            // Arrange
            Triangle tri1 = new Triangle(2, 2, 9);
            Triangle tri2 = new Triangle(21, 3, 9);
            Triangle tri3 = new Triangle(1, 3, 9);
            List<Triangle> expected = new List<Triangle> { };
            // Act
            Triangle.ClearAll();
            // Assert
            CollectionAssert.AreEqual(expected, Triangle.GetAll());
        }
    }
}
