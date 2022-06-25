namespace FigureAreasExample;

using System;
using SimpleFigureAreas;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle((5, 4, 3));
        Console.WriteLine(triangle.GetArea());
        Console.WriteLine(triangle.IsRight);

        Figure circle = new Circle(5);
    }
}