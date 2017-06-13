using System;

namespace CodingSolution.Domain
{
    /// <summary>
    /// Class is immutable
    /// </summary>
    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator == (Point x, Point y)
        {
            return
                Object.ReferenceEquals(x, y) ||
                ((Object)x == null && (Object)y == null) ||
                ((Object)x != null && x.Equals(y));
        }

        public static bool operator != (Point x, Point y)
        {
            return !(x == y);
        }

        public override bool Equals(object obj)
        {
            var point = obj as Point;
            
            return 
                point != null && 
                X == point.X && 
                Y == point.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + X;
                hash = hash * 31 + Y;
                return hash;
            }

        }
    }
}
