using FigureLib.Figures.Abstractions;

namespace FigureLib.Figures;

public class Triangle: Shape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Side lengths must be positive");
        }

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("Triangle inequality violated");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double GetArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngle()
    {
        return SideA * SideA + SideB * SideB == SideC * SideC
               || SideA * SideA + SideC * SideC == SideB * SideB
               || SideB * SideB + SideC * SideC == SideA * SideA;
    }
}