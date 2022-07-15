namespace AreaCalculationLib.Figures;

public class Circle : Figure
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    private double Radius
    {
        init
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_radius),"Radius cannot be equal or less than 0");
            }
            _radius = value;
        }
    }

    public override double Area()
    {
        Console.WriteLine("That's a circle. It's area is:");
        return Math.PI * _radius * _radius;
    }
}