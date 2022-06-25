using System;
using Xunit;
using SimpleFigureAreas;

namespace FigureAreasTests;

public class CircleTests
{
    [Fact]
    public void CircleCreationTest()
    {
        uint radius = 5;
        Circle circle = new Circle(radius);
        Assert.Equal(circle.Radius, radius);

        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void CircleAreaTest()
    {
        // проверка осуществляется без "знания типа" фигуры
        Figure circle = new Circle(5);
        Assert.Equal(78.54, Math.Round(circle.GetArea(), 2));
        circle = new Circle(1);
        Assert.Equal(Math.PI, circle.GetArea());
    }
    
    [Fact]
    public void CircleStringTest()
    {
        Circle circle = new Circle(5);
        Assert.Equal("Circle with Radius = 5", circle.ToString());
    }
}