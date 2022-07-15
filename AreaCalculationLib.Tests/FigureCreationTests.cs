using System;
using Xunit;

namespace AreaCalculationLib.Tests;

public class FigureCreationTests
{
    [Fact]
    public void CircleCreationValidation_ShouldPass()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => FigureCreator.CreateFigure(-3));
    }
    
    [Fact]
    public void TriangleCreationValidation_ShouldPass()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => FigureCreator.CreateFigure(-3, 2, 0));
    }
}