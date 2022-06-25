namespace FigureAreasExample;

using System;
using SimpleFigureAreas;

class Program
{
    static void Main(string[] args)
    {
        List<Figure> figures = new List<Figure>();
        for (uint i = 0; i <= 10; ++i)
        {
            if (i % 2 == 0)
                figures.Add(new Triangle((i + 2, i + 4, i + 5)));
            else
                figures.Add(new Circle(i));
        }

        foreach (var figure in figures)
            Console.WriteLine($"The area of {figure.ToString()} is {Math.Round(figure.GetArea(), 2)}.");
    }
}