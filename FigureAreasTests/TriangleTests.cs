using System;
using Xunit;
using SimpleFigureAreas;

namespace FigureAreasTests;

public class TriangleTests
{
    [Fact]
    public void TriangleCreationTest()
    {
        (uint first, uint second, uint third) sides = (2, 4, 5);
        Triangle triangle = new Triangle(sides);
        Assert.Equal(triangle.Sides, sides);

        Assert.Throws<ArgumentException>(() => new Triangle((1, 4, 5)));
        Assert.Throws<ArgumentException>(() => new Triangle((0, 5, 5)));
    }

    [Fact]
    public void TriangleAreaTest()
    {
        // проверка осуществляется без "знания типа" фигуры
        Figure triangle = new Triangle((3, 4, 5));
        Assert.Equal(6, triangle.GetArea());
        triangle = new Triangle((5, 6, 7));
        Assert.Equal(14.7, Math.Round(triangle.GetArea(), 1));
    }

    [Fact]
    public void TrianglePerimeterTest()
    {
        Triangle triangle = new Triangle((3, 4, 5));
        Assert.Equal((uint)12, triangle.Perimeter);
    }

    [Fact]
    public void TriangleIsRightTest()
    {
        Triangle triangle = new Triangle((3, 4, 5));
        Assert.True(triangle.IsRight);
        triangle.Sides = (2, 4, 5);
        Assert.False(triangle.IsRight);
    }

    [Fact]
    public void TriangleStringTest()
    {
        Triangle triangle = new Triangle((3, 4, 5));
        Assert.Equal("Triangle with sides (3, 4, 5)", triangle.ToString());
    }
}