using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingSolution.Domain;

namespace CodingSolution.Tests.Domain
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void SquareToTriangle()
        {
            // Arrange
            var square = new Square(new Point(0,0), 10);

            // Act
            var triangles = square.ToTriangle();

            // Assert
            Assert.IsTrue(triangles.Count == 2);
            Assert.IsTrue(
                triangles[0].Vertices.Contains(new Point(0, 0)) &&
                triangles[0].Vertices.Contains(new Point(10, 10)) &&
                triangles[0].Vertices.Contains(new Point(0, 10)));
            Assert.IsTrue(
                triangles[1].Vertices.Contains(new Point(0, 0)) &&
                triangles[1].Vertices.Contains(new Point(10, 10)) &&
                triangles[1].Vertices.Contains(new Point(10, 0)));

        }

        [TestMethod]
        public void SquaresToTriangle()
        {
            // Arrange
            var squares = new[] {
                new Square(new Point(0,0), 10),
                new Square(new Point(0,10), 10),
                new Square(new Point(10,0), 10),
                new Square(new Point(10,10), 10)
            };

            // Act
            var triangles = squares.ToTriangle();

            // Assert
            Assert.IsTrue(triangles.Count == 8);
            Assert.IsTrue(
                triangles[0].Vertices.Contains(new Point(0, 0)) &&
                triangles[0].Vertices.Contains(new Point(10, 10)) &&
                triangles[0].Vertices.Contains(new Point(0, 10)));
            Assert.IsTrue(
                triangles[6].Vertices.Contains(new Point(10, 10)) &&
                triangles[6].Vertices.Contains(new Point(20, 20)) &&
                triangles[6].Vertices.Contains(new Point(10, 20)));
        }
    }
}
