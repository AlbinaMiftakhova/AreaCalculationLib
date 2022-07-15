namespace AreaCalculationLib.Figures;

public class Triangle : Figure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private double SideA
    {
        init
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_sideA), "Side A cannot be equal or less than 0");
            }
            _sideA = value;
        }
    }

    private double SideB
    {
        init
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_sideB), "Side B cannot be equal or less than 0");
            }
            _sideB = value;
        }
    }

    private double SideC
    {
        init
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_sideC), "Side C cannot be equal or less than 0");
            }
            _sideC = value;
        }
    }

    public override double Area()
    {
        Console.WriteLine(IsRightTriangle()
            ? "That's a right triangle. It's area is:"
            : "That's a triangle. It's area is:");

        var halfPerimeter = _sideA + _sideB + _sideC;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
    }

    /// <summary>
    /// Проверка на то, является ли треугольник прямоугольным
    /// </summary>
    /// <returns></returns>
    public bool IsRightTriangle()
    {
        return _sideA * _sideA == _sideB * _sideB + _sideC * _sideC || 
               _sideB * _sideB == _sideA * _sideA + _sideC * _sideC ||
               _sideC * _sideC == _sideB * _sideB + _sideA * _sideA;
    }
}