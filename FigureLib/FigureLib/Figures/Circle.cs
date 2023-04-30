using FigureLib.Figures.Abstractions;

namespace FigureLib.Figures;

public class Circle: Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive", nameof(radius));
        }

        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}