using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingSolution.Domain;

namespace CodingSolution.Tests.Domain
{
    [TestClass]
    public class GridBuilderTests
    {
        [TestMethod]
        public void GridWithOneSquare()
        {
            // Arrange
            GridBuilder gridBuilder = new GridBuilder();

            // Act
            var grid = gridBuilder
                .HasWidth(10)
                .Build();

            // Assert
            Assert.IsTrue(grid.Count == 1);
            Assert.IsTrue(grid[0].TopLeft == new Point(0, 0));
            Assert.IsTrue(grid[0].BottomRight == new Point(10, 10));
        }

        [TestMethod]
        public void GridWithOneRowAndFiveColumns()
        {
            // Arrange
            var gridBuilder = new GridBuilder();

            // Act
            var grid = gridBuilder
                .HasWidth(10)
                .WithColumns(5)
                .Build();

            // Assert
            Assert.IsTrue(grid.Count == 5);
            Assert.IsTrue(grid[0].TopLeft == new Point(0, 0));
            Assert.IsTrue(grid[4].BottomRight == new Point(50, 10));
        }

        [TestMethod]
        public void GridWithFiveRowsAndOneColumn()
        {
            // Arrange
            var gridBuilder = new GridBuilder();

            // Act
            var grid = gridBuilder
                .HasWidth(10)
                .WithRows(5)
                .Build();

            // Assert
            Assert.IsTrue(grid.Count == 5);
            Assert.IsTrue(grid[0].TopLeft == new Point(0, 0));
            Assert.IsTrue(grid[4].BottomRight == new Point(10, 50));
        }

        [TestMethod]
        public void GetRowNumberFromTriangle()
        {
            // Arrange
            var triangle = new Triangle(new Point(100, 0), new Point(110, 0), new Point(110, 10));

            // Act
            var row = triangle.GetRowNumber();

            // Assert
            Assert.IsTrue(row == 10);
        }

        [TestMethod]
        public void GetColumnNumberFromTriangle()
        {
            // Arrange
            var triangle = new Triangle(new Point(0, 100), new Point(10, 100), new Point(10, 110));

            // Act
            var column = triangle.GetColumnNumber();

            // Assert
            Assert.IsTrue(column == 10);
        }
    }
}
