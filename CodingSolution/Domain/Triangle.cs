using System.Collections.Generic;

namespace CodingSolution.Domain
{
    public class Triangle
    {
        public IList<Point> Vertices { get; }

        public Triangle(Point v1, Point v2, Point v3)
        {
            Vertices = new[] { v1, v2, v3 };
        }
    }

    public static class TriangeExtensions
    {
        public static IList<Triangle> ToTriangles(this Square square)
        {
            return new[] {
                new Triangle(square.TopLeft, square.BottomRight, square.BottomLeft),
                new Triangle(square.TopLeft, square.BottomRight, square.TopRight),
            };

        }

        public static IList<Triangle> ToTriangles(this IList<Square> squares)
        {
            var triangles = new List<Triangle>();
            foreach(var square in squares)
            {
                triangles.AddRange(square.ToTriangles());
            }

            return triangles;
        }
    }
}
