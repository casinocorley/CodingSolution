using System.Collections.Generic;
using System.Linq;

namespace CodingSolution.Domain
{
    public class GridBuilder
    {
        Point StartingPoint { get; set; } = new Point(0, 0);
        int Width { get; set; }
        int ColumnLength { get; set; } = 1;
        int RowLength { get; set; } = 1;


        public GridBuilder StartsAt(Point startingPoint)
        {
            StartingPoint = startingPoint;
            return this;
        }

        public GridBuilder HasWidth(int value)
        {
            Width = value;
            return this;
        }

        public GridBuilder WithColumns(int value)
        {
            ColumnLength = value;
            return this;
        }

        public GridBuilder WithRows(int value)
        {
            RowLength = value;
            return this;
        }

        public IList<Square> Build()
        {
            var grid = new List<Square>();

            for (int i = 0; i < RowLength; i++)
            {
                var rowStartingPoint = new Point(StartingPoint.X, StartingPoint.Y + (i * Width));
                var row = CreateRow(rowStartingPoint, Width, ColumnLength);
                grid.AddRange(row);
            }

            return grid;
        }

        public IList<Square> CreateRow(Point topLeft, int width, int numberofColumns)
        {
            return CreateRow(new Square(topLeft, width), numberofColumns);
        }

        public IList<Square> CreateRow(Square firstSquare, int numberOfcolumns)
        {
            var row = new List<Square> { firstSquare };

            for (int i = 1; i < numberOfcolumns; i++)
            {
                var topLeftX = firstSquare.TopLeft.X + (i * firstSquare.Width);
                var topLeft = new Point(topLeftX, firstSquare.TopLeft.Y);

                row.Add(new Square(topLeft, firstSquare.Width));
            }

            return row;
        }
    }

    public static class GridBuilderExtensions
    {
        public static int GetRowNumber(this Triangle triangle)
        {
            var xValues = triangle
                 .Vertices
                 .Select(vertex => vertex.X);

           var minX = xValues
                .Min();

            var maxX = xValues
                .Max();

            var width = maxX - minX;

            return minX / width;
        }
        public static int GetColumnNumber(this Triangle triangle)
        {
            var yValues = triangle
                .Vertices
                .Select(vertex => vertex.Y);

            var minY = yValues
                .Min();

            var maxY = yValues
                .Max();

            var width = maxY - minY;

            return minY / width;
        }
    }
}
