using AreaCalculationLib.Figures;
using Xunit;

namespace AreaCalculationLib.Tests;

public class AreaCalculationTests
{
    [Fact]
    public void CircleAreaCalculation_ShouldPass()
    {
        var circle = FigureCreator.CreateFigure(3);
        var area = circle.Area();
        Assert.Equal(28.274333882308138, area);
    }
    
    [Fact]
    public void TriangleAreaCalculation_ShouldPass()
    {
        var triangle = FigureCreator.CreateFigure(3, 4, 5);
        var area = triangle.Area();
        Assert.Equal(77.76888838089432, area);
    }
    
    [Fact]
    public void TriangleAreaCalculation_IsRightTriangleValidation_ShouldPass()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        var isRight = triangle.IsRightTriangle();
        Assert.False(isRight);
    }
}