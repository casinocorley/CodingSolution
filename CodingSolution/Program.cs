using CodingSolution.Domain;

namespace CodingSolution
{
    /// <summary>
    /// Author: Casino Corley
    /// Date: 6/12/17
    /// Description: Solution to coding exercise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1: Get Triangle Coordinates
            var triangles = GridBuilder
                .Grid()
                .HasWidth(10)
                .WithColumns(6)
                .WithRows(6)
                .Build()
                .ToTriangles();

            // Exercise 2: Get row and column number of a triangle
            var rowNumber = triangles[10].GetRowNumber();
            var columnNumber = triangles[10].GetColumnNumber();
        }


    }
}
