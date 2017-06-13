using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingSolution.Domain;

namespace CodingSolution.Tests.Domain
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void CanConstructValidSquare()
        {
            // Arrange

            // Act
            var square = new Square(new Point(0, 0), 10);

            // Assert
            Assert.IsTrue(square.Width == 10);
            Assert.IsTrue(square.TopLeft == new Point(0, 0));
            Assert.IsTrue(square.TopRight == new Point(10, 0));
            Assert.IsTrue(square.BottomLeft == new Point(0, 10));
            Assert.IsTrue(square.BottomRight == new Point(10, 10));
        }
    }
}
