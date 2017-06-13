namespace CodingSolution.Domain
{
    /// <summary>
    /// Class is immutable
    /// </summary>
    public class Square
    {
        public Square(Point topLeft, int width)
        {
            TopLeft = topLeft;
            Width = width;
            TopRight = new Point(topLeft.X + Width, topLeft.Y);
            BottomLeft = new Point(topLeft.X, topLeft.Y + Width);
            BottomRight = new Point(topLeft.X + Width, topLeft.Y + Width);
        }
        public int Width { get; }
        public Point BottomLeft { get; }
        public Point BottomRight { get; }
        public Point TopLeft { get; }
        public Point TopRight { get; }
    }
}
