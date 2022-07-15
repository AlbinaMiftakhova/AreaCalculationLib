using AreaCalculationLib.Figures;

namespace AreaCalculationLib;

public static class FigureCreator
{
    public static Figure CreateFigure(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }

    public static Figure CreateFigure(double radius)
    {
        return new Circle(radius);
    }
}