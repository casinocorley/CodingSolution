using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingSolution.Domain;

namespace CodingSolution.Tests.Domain
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void EqualToItself()
        {
            // Arrange
            var point = new Point(0,0);

#pragma warning disable CS1718 // Comparison made to same variable
            // Act
            var isEqual = point == point;
#pragma warning restore CS1718 // Comparison made to same variable

            // Assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void EqualWhenXandYAreEqual()
        {
            // Arrange
            var pointA = new Point(1, 1);
            var pointB = new Point(1, 1);

            // Act
            var isEqual = pointA == pointB;

            // Assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void NotEqualWhenDifferent()
        {
            // Arrange
            var pointA = new Point(0, 0);
            var pointB = new Point(0, 1);

            // Act
            var isEqual = pointA == pointB;

            // Assert
            Assert.IsFalse(isEqual);
        }
        
        [TestMethod]
        public void NotEqualWhenOneIsNull()
        {
            // Arrange
            var pointA = (Point)null;
            var pointB = new Point(0, 0);

            // Acct
            var isEqual = 
                pointA == pointB || 
                pointB == pointA;

            // Assert
            Assert.IsFalse(isEqual);
        }
    }
}
